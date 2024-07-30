// function tocaSomPom (){
//     document.querySelector('#som_tecla_pom').play();
// }

// function tocaSomClap(){
//     document.querySelector('#som_tecla_clap').play();
// }

function tocaSom (seletorAudio){
    const elemento = document.querySelector(seletorAudio);
    
    if(elemento != null && elemento.localName === 'audio' ){
            elemento.play(); 
    }
    else{
        alert('elemento não encontrado ou seletor invalido')
    }
    
}


// /para guardar a referencia dentro de uma classe não se usa()/ 
// document.querySelector('.tecla_pom').onclick = tocaSomPom;

// criando uma lista de teclas para melhor entendimento do codigo
const listaDeTeclas = document.querySelectorAll('.tecla');

//let contador=0;

// listaDeTeclas[0].onclick = tocaSomPom;
// listaDeTeclas[1].onclick = tocaSomClap;

//enquanto
/*
while ( contador < listaDeTeclas.length) {

    const tecla= listaDeTeclas[contador];
    const instrumento =tecla.classList[1];

    //console.log(instrumento)

    //teplate instring
    const idAudio= `#som_${instrumento}`

    //console.log(idAudio);

    tecla.onclick= function(){
        tocaSom(idAudio);
    }
    contador= contador + 1;

    console.log(contador);
   
}
*/


//para
for (let contador = 0 ;  contador < listaDeTeclas.length; contador ++){
    const tecla= listaDeTeclas[contador];
    const instrumento = tecla.classList[1];
    const idAudio = `#som_${instrumento}`//template string
    
    tecla.onclick = function(){
        tocaSom(idAudio);
    }

    tecla.onkeydown = function(evento){
        if(evento.code == 'Space' || evento.code ==='Enter'){
            tecla.classList.add('ativa');
        }
    }

    tecla.onkeyup = function(){
        tecla.classList.remove('ativa');
    }

}








/// pratica



// function tocaSom2(seletorAudio){
//     const elemento = document.querySelector(seletorAudio)
//     if (elemento != null && elemento.localName ==='audio' ){
//         elemento.play();
//     }
//     else{
//         alert('elementou ou seletor não é valido')
//     }
// }

// const listaDeTeclas2 = document.querySelectorAll('.tecla');

// for(let contador2 = 0 ; contador2 < listaDeTeclas2.length; contador++){
//     const tecla2 = listaDeTeclas2[contador2];
//     const instrumento2 = tecla2.classList[1];
//     const idAudio2 = `#som_${instrumento2}`;

//     tecla2.onclick = function(){
//         tocaSom2(idAudio2);
//     }

//     tecla2.onkeydown = function(evento){
//         if(evento.code=='Space' || evento.code =='Enter' ){
//             tecla2.classList.add('ativa');
//         }
//     }
//     tecla2.onkeyup = function(){
//         tecla2.classList.remove('ativa');
//     }

// }

