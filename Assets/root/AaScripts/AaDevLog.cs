#region Primeros20Dias
/*

Dia0(07-11-22):
Trabajado en PlayerHook, PlayerGroundCheck, PlayerMovement, PlayerJump
Ninguna perfeccionada, pero todas mas menos funcionan, tambien creado el proyecto y creado el repositorio en github


Dia1(08-11-22):
PlayerHook ahora solo se puede usar una vez, coyote jump, jump buffering, y doble salto funciona guay(tocara cambiarlo pero en principio bases solidas)
Se suponia que iba alimpiar codigo hoy, pero al final no lo he hecho(se ha complicado el tema de el salto)
metido el mapa de adrian aunque no se si eso esyaba ya ayer,
ma�ana molaria:
----------------------
TODO(En prioridad):
Limpiar codigo: :)
Bug Camara: :)
Aa: :)
Hacer sistema de vida solido: :/
a�adirlo al hud: :(
Hacer enemigos basicos: :/
A�adir Parry: :/

----------------------

Dia2:(09-11-22):
--
Hecho por la ma�ana
A�adidos ataques(con cubos)
vida basica(no hay nada q te quite vida)
doble salto visual
arreglado bug camara
limpiado codigo
rotaionpersonaje(capsula) arreglado
--
Tarde

Dia3:(09-11-22):
--
A�adido enegimo pocho
Lo estoy escribiendo el domingo y ns q hice jaja
--
Fin de semana1:
A�adido nuevo sistema de enemigo un poco mejor,(no programado pero por lo menos esta muy setteado para ma�ana.

Dia4(13-11-23):
Hecho Por la Ma�ana:
Enemigo(por pullir obb pero bastante mejor q el del otro dia)
Parry(funciona la parte del enemigo(lo stunea)) falta meteer que recuperes vida
Movimiento adicional camara(jostic derecho abajo mueve la camara abajo)
Metido el mapa y ajustes de pablo
Ahora me voy a poner con el cambio de sentido(q lo haga mas rapido)(ns si acabare ahora o por la tarde)
Cambio de sentido terminado
Hecho x la tarde:
empezado sistema respawn
solucion pocha de camera boundaries
investigado mas sobre el enemigo
----
hacer ma�ana:
DEJAR CLARO TODA LA PROGRAMACION Q VOY A NECESITAR
si eso terminar respawn.

Dia5:
A�adidas todas las cosas que se me han podido ocurrir al trello
Terminado respawn con los altares
solucionado problema rotacion camara al reaparecer.
investigado sobre camera boundaries, de momento he encontrado una solucion super pocha(ma�ana preguntar en clase)
Hcaer ma�ana:
A�adir player hit y si tengo tiempo Aa


Dia6:
hecho por la ma�ana:
A�adido player Hit
A�adido Aa aereo vertical y horizontal
a�adido sprite temporal del enemigo, hechas animaciones pochas para este enemigo, y mejorado el enemigo(ahora te emppuja bn y toda la pesca)
A�adido q mueras, te hagas invisible y aprarezcas

para hacer por la tarde:
mejorar enemigo a full y hacer enemigo volador si tengo timepo

Tarde:
Trabajado en mejorar el enemigo:
quitado RB, ahora se mueve por movetowards, quitado todos los colliders, el enemigo te empuja, pero lo puedes atravesar.
si caes por encima de el, no te empuja, te relentiza y lo atraviesas. igual q si le saltas, para asi no cortar el salto(blaspgemous)
No tiene puntos muertos ya(en los q te podias quedar y se quedaba pegando a la nada.)
el personaje se hace inbulnerable tgemporalmente cunado le golpean
cambiado el modo de hacer el parry(ahora va por una variable que esta en el gamemanager)




Dia7:
Alargado aa
a�adido enemigo volador(programado movimiento)
Pensado sistema oleadas, cristal que spawnea enemigos
Mejorado player hit.
a�adido que el parry stune al enemigo volador


Dia8:

PECH:

En Fate podemos separar las mec�nicas del personaje en dos apartados. Adem�s de las mec�nicas b�sicas de un metroidvania (correr y salto) 
al final del salto puedes volver a pulsar el bot�n para realizar un peque�o impulso con el que poder llegar m�s lejos.
Adem�s, con el ataque principal recuperas cierta cantidad de vida.

En Fate, las mecanicas se podrian dividir en dos secciones, las habilidades basicas del personaje, como serian los auto ataques,
el salto el movimiento, o el parry y las habilidades obtenidas por el personaje a lo largo del nivel

Dentro de las mec�nicas mas compejas en Fate, podriamos encontrar el parry y el gancho. El parry, es una habilidad que al ser usada, protejera
al personaje durante un brebe periodo de timepo, en el cual si el personaje es atacado, blockeara y devolvera este ataque,
stuneando al enemigo atacante. Esta habilidad consumira un % de vida, que sera devuelto en caso de de acertar la habilidad.

Por otro lado, el gancho, te permitira llegar a sitios a los cuales no podrias llegar con la movilidad base del personaje,
desbloqueando asi, formas de esquivar los ataques de los enemigos, y zonas del mapa.

Finalmente, y un poco menos compleja estaria el doble salto, que como su nombre indica, te permitiria inpulsarte una vez mas durante el salto.
Esto te permitira tener mayor movilidad, asi como acceder a zones que antes no podias.


En cuanto a mecanicas del entorno, podriamos dividirlas tambien en dos secciones, Interactuables por el persoanje, y que que afectan sobre el.

En cuanto a las que afectan sobre el, tenemos las basicas, como el enemigo mele,
Este, estara patrullando una zona, y una vez te vea, este te perseguira y atacara, sus ataques seran poderosos pero lentos, por lo que usar 
el parry, sera la mejor opcon para derrotarlo.
El enemigo volador, Estara fijo en una zona, y cunado te vea, se lanzara a por ti comom un kamikaze, golpeandote o explotando contra el suelo.

En cunato a otras cosas que tendras que tener en cunata durante el nivel, podrian tambien encontrase trampas de pinchos en el suelo.



------------
Cambiado enemigo volador, ahora te ve, y se lanza a por ti, explotando tanto si impacta contigo como si impacta con el suelo.

hacer ahora/despues del patio:
Cambiar funcionamiento parry





Dia9(21-11-2023):
Arreglado bug al iniciar la partida

A�adido desblockeo de salto, limpiado codigo, comentado codigo y corregido bugs como doble cliuck hace qye sates mas alto,
a�adir ahora que no te deje hacer doble salto con menos de x distancia al suelo.

A�adida zona que desbloquea el salto
mejorado el salto en general

arreglar salto y cambio de direccion

corregir bug aa hace que saltes menos

Me pase a ayudar con buscar refes el resto del dia

Dia 10(22/11/23):

corregir bug aa hace que saltes menos
Solucionado bug aa hace q salte mensos.

Corregido bug q si te mueves saltas menos por tema de drag:
solucionado poniendo drag a 0 cunado saltas(por si diese problemas mas adelantes)


salto y cambio de direccion se sobreescriben
Solucionado cambio de direccion se sobreescriben

modificado el generic health, para que sirva para todos los enemigos.

Empezado sistema rondas, entras, se cierran las puertas y aparecen una cantidad de enemigos dependiendo de la ronda, en zonas aleatorias.(solo mele)
Ma�ana terminarlo del todo:
Si mueres se reinicia,
que funcionen las rondas,
que aparezcan los voladores etc.





Dia11(23/11/23):

trabajado en sistema de oleadas

muerte reinicia la sala por completo
sistema de rondas mejorado para q funcionen con los voladores(no a�adidos aun)
romper el cristal hace que se abran las puertas y superes la sala.



Dia12(24/11/23):
A�adidos enemigos voladores, hecho que funcionen las oleadas con ellos tambien,
Cambiado sistema de respawn(GameobjList)Preguntar jorge.
Solucionar errores sistema oleadas.


Dia13:
TodoList Hoy:
A�adir respawn infinito: hecho
Actualizar Trello: hecho

--
Parry ahora no te puede matar
Parry ahora cancela aa, lo que hace que responda antes.
Barra de vida se actualiza con todo(golpes,ataques,etc.)

ordenado carpetas y actualizado el main de todos






Dia14:

TodoList hacer ma�ana(o al terminar las prioridades nuevas al hablar con jorge:
Vida boss: a medias
effecto hacer da�o boss: a medias
matar boss: otro dia
entrar en sala boss: otro dia
meter todo el graybox: otro dia

--preguntar jorge hasta que punto es worth usar interfazes cuando me obliga a hacer el metodo publico--
no lo es, quitar
----------
a�adidas interfaces de ikilleable, idamageable y healplayer
x la ma�ana, empezado a hacer boss, pero me he desviado a hacer interfaces y aplicarlas a los enemigos.

hacer por la tarde:

1: Arreglar takedamage de los enemigos--Ok
2: revisar el playerheal--Ok

3: 
a venido jorge, nueva to do list con prioridades:
cambiar instancias objetos x object polling--Problema, solucinar ma�ana en clase
cambiar lista y referencias de la sala de rondas al roundManager--Ok
   

Dejar codigo limpio para ma�ana poder hacerlo/solucinarlo con jorge--Ok
quitado trabajo fin de semana q hay q mejorar,--Ok
mejorado enemigos volador y normal.--Ok
a�adido instancia de enemigos al entrar en la sala de rondas(inicio de object booling)--Ok



Dia15:

Mejoras enemigo:
Ahora se espera u poco cuando te sales de su zona, lo que hace q no parezca como q te esta siguiendo todo el rato,--Ok
si esta atacando no se gira--Ok
siempre mira donde toca.--Ok
te empuja hacia afuera siempre--No, casi siempre si, pero ns cuando no lo hace.

BossFight:
Vida boss--Ok
effecto hacer da�o boss--Ok
EntradaALaHabitacion--Ok
matar boss--Ok





Dia16:
empezado a trabajar en las oleadas con el nuevo sistema y con el object pooling.
intentado arreglar rondas con object pool, preguntar jorge.


usar awake para buscar variables y start para definir valores(cambiar todas clases a esto)--Ok
Estoy usando algunas interfaces comom ihealplayer solo para saber si curarle, si tener en cuneta nada mas, ns si eso es productivo o no(cambiar por clases vacias)--Ok
XQ CUNADO LE DAS A ALGO Y NO PUEDES HCARELO EN EL MOMENTO, L HACE AL TERMINAR LA ACCION(arreglado x codigo)--Ok
Solucionar bug deslizar al aparecer(otra vez)(ES LA GRAVEDAD)--Ok

Arreglar problemas con player--Ok(no arreglado cosas, pero como de momento lo dejo un poco mas de lado, me centro mejor en arreglar las salas.

Arreglar sistema salas hoy(para ponerme a modelar ma�ana.(imposible xd) imposible mis cojones lest goooo(despuies de como toda la tarde xdd)

cunado desactivo al enemigo, se queda mitad animacion para siempre.(desactivar sprite)--Ok


-----
co�a xq esto tiene tela:
Restructurado enemigo melee por complete, usado scrips antiguos y nuevos, a�adido a la lista de prioridades cambiar los scripts antiguos por los nuievos
ahora las rondas funcionan con el enemigo mele, meter ma�ana que funcionen tambien con los voladores y el cristal(y toda la pesca)

arreglar ma�ana seguro el tema del parry



FinDeSemana(Dia17):
A�adido enemigo volador al sistema de rondas(falta perfeccionar mucho)
solucionados problemas que habian con el sistema de rondas.
cambiado un poco el funcionamiento de los scrips del enemigo volador

Resto del fin de semana super chill;




Dia18(05/12/23):

Quitado temporalmente el spawn infinito de voladores en la sala de rondas, ahora funciona guay sin eso.(perfeccionar enemigos e interacciones con enemigos 

SOlucinar aa y parry sobreescriben y se buggea xd-- parece q Ok

Attaque del disco boss--ok
metter sprite boss-Estrutura basica boss--Ok
attaque pinchos--Ok


Puente:

Terminar graybox
A�adir nuevo sistema camera boundaries
a�adir miniMapa basico


Dia19:
Mejorado nuevo sistema camaras, a�adido bloques que delemitan boundaries
a�adida camara de los pasillos(camara estable que te sigue por el pasillo) No implementada en todos los pasillos
a�adida sala grande con scripts modificados para que la camara funcione bien, la transicion sea smooth y no se salga de la sala.

quitado todos los colliders de todas las salas.
a�adidos colliders para suelo paredes techo
a�adido tp al final de primer piso que te lleva al segundo

cosas que faltan:
A�adir boundaries salas 3,4,6--Ok
meter movimiento puente--Ok
meter transicion al boss.--Ok


Hacer ma�ana:
Dejar claras dimensiones salas que ahora mismo no funcionan, ponerme con movimiento del pj



Dia20:

Trabajando en bugs del salto:

te deja hacer 2 saltos si lo haces rapido--Sol

Si mantienes en movimiento vuelve a saltar, quieto no(dejar para mas adelante)

Poner spawnpoints--Ok

Sala rondas:

hecho animaciones abrir y cerrar puertas--Ok

Mejorar pilares que caen, y hacer que te maten bn--Ok

Hacer por la tarde:
A�adir sistema rondas, muerte restablece sala, si superas la sala te vas.

De momento:
si te mueres se reinicia todo bienm, despues comprobar si hace las rondas bn(sin infinito)--Ok





Dia 21:
rafaga aa.--Ok(de momento)
hacer que enemigo volador se mueva--Ok
Eliminado enemigo volador--Ok
Borrar scrips que tienen que ver con enemigo volador--Ok
Arreglado bug que buffer jump no salta igual si estas quieto que en moviemineto(no lo tenia en mente pero se me ha ocurrido de la nada)

Hacer x la tarde:
A�adir cristal, que te dispare y atraviese plataformas pero no paredes--

Antes que se me olvide, quiero meter un enevnto de esos, para que las salas como la del boss o la sala de rondas se puedan suscribir cunado el pj entra,
y si muere que desde el playerHealth lo llame, por lo tanto, el pj simepre que muere llama al evento ese, si no estas en la sala de rondas, no pasa anda,
si estas, como el script de la sala de rondas habra a�adido un metodo que reinicie la sala a ese evento, se reiniciara.lo mismo con la del boss--
(ahora toca hacerlo xd)



Dia22:

Solucionado y a�adido tema nuevas ramas, problemas con ramas, organizacion de carpetas, etc.
a�adido que aparezca el cristal en las rondas--ok
a�adir que para pasar de ronda el cirstal tiene que estar roto--Ok

Hacer por la tarde:
a�adir que al morir se restablezca la sala--Ok
corregir camara al entrar en sala--(solucionCutreTEMP)--Ok

Solucionar punto PivoteBoss--Ok
Empezar boss--Ok
Hacer barra vida pocha--Ok

Hacer ma�ana:
A�adir "Final" pocho
A�dir menus si eso
Creditos: x to skip
Trabajar en el boss

Dia23:

Pedir y apuntar feedback
A�adido parar en seco al saltar
nerfeo robo vida
reducida duracion parry


Ahbora no puedes hacer el parry durante Gamemanager.instance.instrongAttack;



Dia24(16/12/23):

Lista:

Copiar al enemigo de blashphemous:
Tempos blashphemous:
estado: quieto,
si te ve te persigue, te mira, te ataca, duracion ataque: 
si hay dos, y consigues q se pongan uno encima del otro, se combierten en el mismo enemigo
Ataca rapido, vuelve y espra un poco para volver a atacar.
Hit:
Stun 1 segundo--Ok
Hit te  quita todas las animaciones--Ok
Tempo aa--Ok
Solucionar problema con player hit y desactivar clases.


Solucionar bug aa arriba pega abajo antes

MOdo berserk


Cambiado layer mask del pj 

Hecho nuevo sistema de camaras entero

Nuevo sistema TP
Hacer ma�ana, mejorar y terminar todo camaras 



Dia25(18/12/23):

Arreglar respawn con camaras:--Ok
para hacer eso, he usado los metodos que ya tenia en CameraManager, cuando pones el respawnpoint, pones currentcam as respawnposcam, y luego cunado mueres usando
el metodo de CameraMangaer, desactivo la currentCam y activo la Respawnposcam, luego pongo currentcam a respawncam

Arreglar gancho feedbackVisual--Ok
Arreglar slide plataformas sala estatua--Ok
hacer que tpfuncione bien--Ok
A�adir unlockCollider--Ok
Terminar camaras`+ camaraBridge(1.6)--Ok
A�adir movvimiento en puete--Ok

PostMa�anaClase:

A�dir Fade-In/Fate-Out--Ok(pero no se usa)

Implementar sala rondas(espero q no de problemas xd)--OK(habra q ajustarla pero estar esta




Empezar a trabajar en la bossfight con medidad nuevas--Ok

A�adir entrada a boss + empezar bossfight--Ok

A�adidos ataques boss, mas interacciones--Ok

A�adido menu basico para entrar--Ok

a�adido delegado en player health para las interacciones(si funciona pasar a otro script)

Hacer ma�ana:


Dia26(19/12/23):
A�adir script mencionado arriba,--Ok
a�adir atajo--Ok
dar a probar build.--Ok
Arreglar enemigos para usar solo un prefab--Ok
A�adirAnimacionEntryEnemigo--Ok
arreglado Tp no funciona de arriba a abajo--Ok
A�adir interactuarPara tp--Ok




Dia27(20/12/23):
Arreglado colliders
a�adidas plataformas del gancho + ajustado sus coliders
a�adidos enemigos al mapa
ajustado tp al boss y al segundo piso


probar build y arreglar bugs:
hacer q trampas se vean--Ok
a�adir algo de sentido a la caida--Ok
hook te para a mitad--
subit enemigos --Ok
CorregirZfight--Ok


al llegar a casa:

Importar assets lucia



 

*/
#endregion
/*




---ViajeChina--
Objetivos:
limpiar codigo
resolver dudas y cosas metidas en la todolist




Dia28(Desde el avion xd):
Arreglar AaDevLog--Ok
A�adir delegado ondeath para el player--Ok(funcional en RoundManager)
Borrar Scripts inutiles--

Dia29(Muy poco tiempo(25/12/23):
hacer merge desde el avion--Ok
corregir problemas merge--Ok
a�adir cosas todolist--Ok
cosas hechas todolist:

-Cambiar punete a Action map distinto
me tengo que ir, a�adido el mapa de acciones:
cosas que hacer al volver:
biorrar los inputs que se ponian al entrar en el puente, a�adir que se cambie de mapa al entrar
creo que ya xd


Dia 30(26/12/23):
Terminar cosas cambiar de mapa en el puente,--Ok
cambiar todas referencias a movimiento tercera persona en lugar de puente--Ok
arreglar tema minimapa y uimanager duplicado--Ok
cambiar transicion a bossfight con nuevo mapa--Ok
arreglar inputs con cambio de nombre del otro mapa--
---------
Problema que a surgido, el cambio de escena al boss, se hace con otro script, no con el mismo que el resto de transiciones, 
la solucion q se me ha ocurrido seria a�adir otra boleana para si lleva a bossfight o no, y en caso de activarla que te pida un metodo que a�adir para empezar la bossfgiht con un timer.
ahora oslo me quedan 30 min, y me tendre que ir, a ver si me da timepo.
puta q me pario otro problema jaja, para el boss no queremos que sea interactuable, queremos que te haga tp sin mas, supongo que por eso no lo he a�adido antes,
SOlucion temporal, te sale texto de desafiar al boss,
----
problema que solucionar proximo dia, no te deja interactuar por el cambio de mapa
a�adir lo mencionado del boss
----


Dia31(30/12/23):

-Mover cosas player del GameManager al playerManager

he movido el healplayer, y he puesto las referencias de lo que se cura el pj en el player manager
creo que no hay mas referencias a la cantidad de vida curada en ningun sitio, pero idk
borrado clases no usadas

Dia32(PostNavidad):
Hacer buuild jorge
--------------


Terminar de mover cosas al player manager:
TODO ESTO:
    public bool canPlayerMove, canPlayerRotate, isOccupied, isPlayerStunned, isPlayerInvulnerable, isPlayerParry;
    [HideInInspector] public int playerDamage;
    public bool inStrongAttack;
    //dobleJump

cosas movidas(y solucionados errores de referencias al cambiar):
canPlayerMove--Ok
canPlayerRotate--Ok
isOccupied--Ok
Cambiado isOcupied por plauerInNormalAa, por que cumplian la misma funcion, y este ultimo es mas claro lo que hace. tmb quitado referencia en el roomtracking al playerinput, ahora la busca en el awake.
isPlayerStunned--Ok
----------
IMPORTANTE: quitado esto de el playerGravity, xq ahora mismo no le veo el uso, alomejor luego falla y toca volver a ponerlo
---------

isPlayerInvulnerable--Ok
isPlayerParry--Ok
playerDamage--Ok
Cambiado por playerCurrentDamage
PlayerHealth--Ok
isPlayerAlive--Ok
inStrongAttack--Ok

canDobleJump--Ok
Limpiado el playerGrouncheck--Ok

IsdobleJumpUnlocked--Ok

-Cambiar muerte a actionMap q no te deja hacer nada--Ok

Dia33(Repite ese numerito):



-----------------------------------------------------------------------------------------------------------------------------------
ToDoList:
-----------------------------------------------------------------------------------------------------------------------------------
-Atajo no funciona bien(Arreglar cunado esten bn hechos los pushes del github)
-Funcionamiento de este boss, te saldra el mensaje de desafiar, y en caso de darle, empezara directamente la bossfiht(hacer cunado github)
-Cuando Termine mirar cosas guardado partida



-Revisar todos los sccrips del melee por nuevos(hechos la mtad o asi)
-A�adir regiones y ordenar codigo
-Cambiar forma de actualizar la vida(usando el get/Set)
-A�adir delegado ondeath para el player--Ok(funcional en RoundManager)---Comprobar y corregir si va mal en la bossfigt---



-----------------------------------------------------------------------------------------------------------------------------------
MAPA MENTAL (Todo lo opcional porbablemnete no sea a�adido de momento):
-----------------------------------------------------------------------------------------------------------------------------------

Objetivos FIN-JUEGO(cosas que faltan por a�adir):
MiniMapa Funcional(Descartado)
Menues
Bossfight
Sonidos
Coleccionables(Descartado)


Cosas que hay que hacer:

-A�adir entrada boss
-Revisar que hacer con el PlayerDefaultDamage
-Modificar collider Parry(De momento estunnea te pegue por donde te pegue)
-Doble salto se deberia poder hacer post hook y dejandote caer de plataforma
-Hacer parry instant
-Cambiar todas referencia hook por interact

BUGS:
-Player No Cae en inicio(de momento np)

-Arreglar bugs Hook:
.si haces parry en la plataforma, dejas de estar en la plataforma.
.si te pegan en mitad se buggea y te quedas ahi volando
.algunas veces te pasas volado y atraviessas los hooks.

-Bugs enemigo melee:
.con parry a veces se buggea y se queda perma stun si haces el parry a destiempo(puede ser que comprube si el player esta ispartying, y en caso de estarlo se vuelve a estunear solo,esto se solucionaria con el cambio delcollider al parry)

-SOlucionar bug tercera persona, si andas alante y te paras luego paras no te deja seguir

-bugs camara:
comprobar que no se sale cunado caes




VFX:
-temblor al morir
-


----------------------------------------------------------------------------------------------------------------------------------
PREGUNTAS:
-----------------------------------------------------------------------------------------------------------------------------------

CAMARAS:
Idea:
hacer colliders del tama�o de cada habitacion, en los que con el ontriggerEnter cambiaria la variable de currentRoom, y esto, con el Get/Set(preguntar como se haria)
te actualizaria las camaras que estan y dejan de estar activas. lo mismo a la hora de morir, miraria cual es el currentSpawnPointCam, y te actualizaria las camaras.


-Para el Ui del parry:
A�ADIDO cooldown parry con dos updates, uno en el uimanager, y otro en el parry, seria mejor con una animacion y un ivnoke?
-Problema con triggers y pasar entre rondas:
Problema con cambio de camaras de habitaciones, que pasa si se queda en medio del colider y vuyelve.
Solucion?
Usar ontriggerExit






------------------
organicacion
-----------------

quedan 4 semanas

-----------------
1 semana sol bugs
-----------------
Bugs que solucionar:
-Cambiar funcionamiento Hook y hacer q funcione bien.
-Bugs camara
-Cambiar buggs parry(Si hay timepo cambiar a q sea solo hacia delante)
-Doble salto se deberia poder hacer post hook y dejandote caer de plataforma
-Enemigos spawnean donde quieren y estan en estados que no tocan.
-A�adir UI parry(circulo)
------------------------------
1 semana meter anims boss y pj
------------------------------
-meter animaicones pj, y solucionar bugs que puedan traer
-meter animaciones boss, hacer los ataques que faltan y terminar la bossfight
-solucionar bugs, y que la bossfght se sienta muy bien.
-arreglar sala rondas para que se entienda que tienes el cristal
-a�adir modo berserk(si todo lo anterior esta bien.)
-------------------------------------
1 semana cerrar juego y arreglar bugs
-------------------------------------
-A�adir menues
-A�adir todo el sonido
-Comprobar que tenemos el juego 100% jugable a escepcion de las animaciones del meelee
-arreglar sala rondas para que se entienda que tienes el cristal
-a�adir modo berserk(si todo lo anterior esta bien.)
--------------------------------
1 semana meter animaciones melee
--------------------------------
-meter animaciones melee y solucionar bugs que puedan traer
-asegurarse de que se siente bien el enemigo
-solucionar bugs del juego
-arreglar sala rondas para que se entienda que tienes el cristal
-a�adir modo berserk(si todo lo anterior esta bien.)

--------------
FIN DEL SPRINT(el juego deberia estar terminado a escepcion de los vfx, iluminacion, cinematicas, etc)
--------------
primera semana febrero: Lunes 5


Segunda y ultima semana: Lunes 12 - Viernes 16

-------------------------
q significa para el resto(hablnado exclusivamente de lo mio)
------------------------
Primera semana:
trabajo libre
Segunda semana: Lunes 15
Animaciones boss y personaje principal y cristal
Tercera semana: Lunes 22
Musica
Sonidos
Arte 2d
Cuarta semana Lunes 29
Animaciones melee

---------------
Recortes
---------------
MiniMapa Funcional(Descartado)


 */