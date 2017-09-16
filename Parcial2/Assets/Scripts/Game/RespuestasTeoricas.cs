/*
 1) El player detecta los colliders que estan cerca con un rango esferico, y detecta si el gameobject del colldier tiene un componente "enemy",
    si lo tiene, apunta hacia la posicion del transform de el gameobject que contiene el "enemy" y dispara en esa dirección.
 2) Como esta el codigo, si hubiera cualquier objeto con el que pudiera colisionar el enemigo entre el y el personaje, este intentaria moverse
    infinitamente hacia el jugador, pero se quedaria atrancado en el obstaculo.
 3) La bala se intancia cada que se presiona un boton del teclado, luego se le pasan los parametros desde el codigo del jugador que la dispara,
    y luego se tira esta bala, añadiendole una fuerza dependiente de los parametros que se le pasaron.
 4) 
 5) El instigator sirve para que la bala se destruya al colisionar con algun objeto, exceptuando al objetoque la instancia para que no se destruya
    inmediatamente al ser creada y pueda salir disparada.
 
 
 
 
*/