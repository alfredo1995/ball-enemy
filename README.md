Configure o player e adicione uma textura

   1. Nahierarquia, crie o objeto 3D >Sphere 
   2. Renomeie-o como "Player", redefina sua posiçãoe aumente sua escala XYZpara 1,5
   3. Adicionar um componente RigidBodyaoPlayer 
   4. NaBiblioteca > Texturas, arraste umatexturapara aesfera

--------------------------- 1.1 Configurando câmera do jogo  ---------------------------

Crie um ponto focal para a câmera

   1. Crie um novoObjeto Vazioe renomeie-o como "Ponto Focal",
   2. Redefina sua posição para a origem (0, 0, 0) e faça da câmera umobjeto filhodela
   3. Crie uma nova pasta "Scripts" e um novo script "RotateCamera" dentro dela
   4. Anexeo script "RotateCamera" aoPonto Focal


Gire o ponto focal pela entrada do usuário

   1. Crie o código para girar a câmera com base emrotationSpeedehorizontalInput
   2. Ajuste o valor da velocidade de rotaçãopara obter a velocidade desejada


--------------------------- 1.2 Configurando movimento do jogador ---------------------------

Adicione força para a frente ao jogador

   1. Crie um novo script "PlayerController", aplique-o aoPlayer e abra-o
   2. Declarar uma nova variável de velocidade de flutuação públicae inicializá-la
   3. Declare um novoRigidbody playerRb privadoe inicialize-o emStart()
   4. EmUpdate(), declare uma nova variável forwardInputcom base na entrada "Vertical"
   5. Chame o método AddForce() para mover o player para a frente com base emforwardInput

Mova-se de acordo com a camera em direção ao ponto focal

   1. Declare um novoGameObject focalPoint privado; e inicializá-lo emStart():focalPoint = GameObject.Find("Ponto Focal");
   2. Na chamada AddForce, substitua Vector3.forward porfocalPoint.transform.forward

--------------------------- 1.3 Configurando inimigo do jogador ---------------------------

Adicione um inimigo e um material de física

   1. Crie uma nova esfera, renomeie-a "Enemy", reposicione-a e arraste uma textura para ela
   2. Adicione um novo componente RigidBody e ajuste sua escala XYZ e, em seguida, teste
   3. Em uma nova pasta "Physics Materials",Crie > Physics Material,em seguida, nomeie-o "Bouncy"
   4. Aumente a recompensa para "1", altereBounce Combinepara "Multiply", aplique-a ao seu jogador e inimigo e, em seguida,teste 


Crie um script inimigo para seguir o jogador

   1. Faça um novo script "Inimigo" e anexe-o aoInimigo
   2. Declarar 3 novas variáveis para Rigidbody enemyRb; ,GameObject jogador; e velocidade de flutuação pública;
   3. Inicializar enemyRb = GetComponent<Rigidbody>(); e player = GameObject.Find("Player");
   4. EmUpdate(), AddForce em direção na direção entre o jogador e o inimigo


         {
             public float speed = 1.0f;
             private Rigidbody enemyRb;
             private GameObject player;

             void Start()
             {
                 enemyRb = GetComponent<Rigidbody>();
                 player = GameObject.Find("Player");
             }
             void Update()
             {
                 enemyRb.AddForce((player.transform.position - transform.position).normalized * speed);
             }
         }
