
from flask import  render_template, request, redirect, session, flash, url_for,send_from_directory
from jogoteca import app,db
from models import *
from helpers import * 
import time

@app.route('/')
def index():
    lista = Jogos.query.order_by(Jogos.id)
    return render_template('lista.html', titulo='Jogos', jogos=lista)

@app.route('/novo')
def novo():
    if 'usuario_logado' not in session or session['usuario_logado'] == None:
        return redirect(url_for('login', proxima=url_for('novo')))
    
    form = FormularioJogo()
    return render_template('novo.html', titulo='Novo Jogo',form = form)

 
@app.route('/editar/<int:id>')
def editar(id):
    if 'usuario_logado' not in session or session['usuario_logado'] == None:
        return redirect(url_for('login', proxima= url_for('index')))
    
    jogo = Jogos.query.filter_by(id=id).first()
    form = FormularioJogo()
    form.nome.data = jogo.nome
    form.categoria.data = jogo.categoria
    form.console.data = jogo.console

    capa_jogo = recupera_imagem(id=id)
    return render_template('editar.html',titulo= 'Editando Jogo',id= id, capa_jogo = capa_jogo,form = form)


@app.route('/deletar/<int:id>')
def deletar(id):
    if 'usuario_logado' not in session or session['usuario_logado'] == None:
        return redirect(url_for('login'))
    
    Jogos.query.filter_by(id=id).delete()
    flash('Jogo Deletado com sucesso')
    db.session.commit()

    return redirect(url_for('index'))

@app.route('/atualizar',methods= ['POST','GET'])
def atualizar():
    form = FormularioJogo(request.form)

    if form.validate_on_submit():

        jogo =Jogos.query.filter_by(id= request.form['id']).first()
        jogo.nome = form.nome.data
        jogo.categoria = form.categoria.data
        jogo.console = form.console.data

        db.session.add(jogo)
        db.session.commit()

        arquivo = request.files['arquivo']
        upload_arquivo = app.config['UPLOAD_PATH']
        timestamp = time.time()
        deletar_imagem(jogo.id)
        arquivo.save(f'{upload_arquivo}/capa{jogo.id}-{timestamp}.jpg')

    return redirect(url_for('index'))

@app.route('/criar', methods=['POST',])
def criar():
    form = FormularioJogo(request.form)

    if not form.validate_on_submit():
        return redirect(url_for('novo'))

    nome = form.nome.data
    categoria = form.categoria.data
    console = form.console.data

    novo_jogo = Jogos.query.filter_by(nome = nome).first()

    if novo_jogo:
        flash('Esse Jogo ja existe!!')
        return redirect(url_for('index'))

    novo_jogo= Jogos(nome=nome,categoria=categoria,console=console)
    db.session.add(novo_jogo)
    db.session.commit()

    upload_path = app.config['UPLOAD_PATH']
    arquivo = request.files['arquivo']
    timestamp = time.time()
    arquivo.save(f'{upload_path}/capa{novo_jogo.id}-{timestamp}.jpg')

    return redirect(url_for('index'))


@app.route('/login')
def login():
    proxima = request.args.get('proxima')
    return render_template('login.html', proxima=proxima)

@app.route('/autenticar', methods=['POST',])
def autenticar():
    usuario = Usuarios.query.filter_by(nickName = request.form['usuario']).first()
    if usuario:
        if request.form['senha'] == usuario.senha:
            session['usuario_logado'] = usuario.nickName
            flash(usuario.nickName + ' logado com sucesso!')
            proxima_pagina = request.form['proxima']
            return redirect(proxima_pagina)
    else:
        flash('Usuário não logado.')
        return redirect(url_for('login'))


@app.route('/logout')
def logout():
    session['usuario_logado'] = None
    flash('Logout efetuado com sucesso!')
    return redirect(url_for('index'))


@app.route('/uploads/<nome_arquivo>')
def imagem(nome_arquivo):
    return send_from_directory('uploads',nome_arquivo)

