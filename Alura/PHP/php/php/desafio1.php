<?php

    for ($numeroImpar = 1; $numeroImpar <= 100 ; $numeroImpar ++ ){
        if($numeroImpar % 3){
            continue;
        }
        echo "$numeroImpar".PHP_EOL;
    }