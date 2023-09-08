var NUMERO1 = Math.floor(Math.random() * 20) + 1; 

var valoringresado = 0; 
let highscore=0;
let mensaje = "";
var puntaje=20; 
var txt_1="";
var mensaje2="";

function habilitar()
{
    txt_1= document.getElementById("txt1").value;
    
    
    var vacio=0;
    
    if(txt_1=="")
    {
        vacio++;
        
    }
    // if(vacio==0)
    // {
    //     document.getElementById("btn1").Disabled=true;
    //     //document.getElementById("display-mensaje").innerHTML ="tiene algo";
    // }
    // else
    // {
    //     document.getElementById("btn1").Disabled=false;
    //     //document.getElementById("display-mensaje").innerHTML ="cadena vacia";        
    // }
}



function playGame()
{ 
    valoringresado = parseInt(document.getElementById("txt1").value);
    //document.getElementById("txt1").addEventListener("keyup",habilitar)
    
    

    if((valoringresado !="")&&valoringresado!=NaN&&valoringresado>0&&valoringresado<21)
    {
        valoringresado = parseInt(document.getElementById("txt1").value);
        //verificar que no repita los numeros con un array, 
        document.getElementById("txt1").value="";
    
        if(puntaje>1)
        {
            if (valoringresado !==NUMERO1)
            {
                puntaje--;
                if(valoringresado <NUMERO1)
                {
                    mensaje =`Intenta otra vez, esta vez con un numero mayor a: ${valoringresado}`;
                }
                else
                {
                    mensaje =`Intenta otra vez, esta vez con un numero menor a: ${valoringresado}`;
                }

                document.getElementById("display-puntaje").innerHTML =`PUNTOS: ${puntaje}`;
                document.getElementById("display-mensaje").innerHTML =mensaje;
                //document.getElementById("display-resultado").innerHTML = `adivinar: ${NUMERO1}`;////////////////////////borrar

            }
            else // GANA
            {
                mensaje =`Haz adivinado!`   
                //btn1.Disabled=true;
                document.getElementById("display-mensaje").innerHTML=mensaje;
                NUMERO1 = Math.floor(Math.random()*20)+1;
            
                if(puntaje>=highscore)
                {
                    highscore=puntaje;
                    mensaje2=`El puntaje máximo hasta el momento es: ${highscore}`;
                    document.getElementById("display-highscore").innerHTML=mensaje2;
                    document.getElementById("display-highscore").textContent;
                    puntaje=20;
                }
                
            }
        }
        else
        {
            mensaje =`Inicia nuevamente`;
            document.getElementById("display-mensaje").innerHTML =mensaje;
            puntaje=0;
            document.getElementById("display-puntaje").innerHTML =`PUNTOS: ${puntaje}`;
            //BLOQUEAR EL BOTON PROBAR
        }
        mensaje =`EL PUNTAJE OBTENIDO ES: ${puntaje}.`;
        //document .getElementById("text1").select();
    }
    else    
    {
        document.getElementById("display-mensaje").innerHTML =`Ingrese un valor válido`;
    }
    
}

function resetGame()
{
    //btn1.Disabled=false;
    puntaje=20;
    NUMERO1 = Math.floor(Math.random()*20)+1;
    document.getElementById("display-puntaje").innerHTML="";
    document.getElementById("display-resultado").innerHTML="A jugar!";
    
    
    limpiar_consola();    
}

function limpiar_consola()
{
    mensaje="";
    //document.getElementById("text1").value="";
    //document.getElementById("text1").select();
    document.getElementById("display-mensaje").innerHTML="";    
}