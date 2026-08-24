#  Loja de RPG - Desafio Theon CEGI

##  Link do Repositório
https://github.com/enzokai1/desafio-loja-theon

##  Como abrir e testar a cena no Unity
1. Faça o download ou clone este repositório para o seu computador.
2. Abra o **Unity Hub**, clique em **Add** (Adicionar projeto a partir do disco) e selecione a pasta descompactada.
3. Abra o projeto (desenvolvido na versão **6000.3.11f1**).
4. No painel _Project_ (abaixo), navegue até à pasta `Assets` (ou `Assets/Scenes`) e dê um duplo clique na cena `SampleScene` para a abrir.
5. Pressione o botão **Play**  no topo do editor para iniciar e testar a loja.

##  Estrutura dos Scripts
O projeto foi dividido em vários scripts diferentes. Assim, fica muito mais fácil organizar o código, encontrar erros e adicionar novidades depois.
* **ItemData (ScriptableObjects):** Utilizados para criar itens de forma fácil e visual pelo Editor, armazenando os dados base (nome, preço, sprite).
* **PlayerInventory:** Gere os dados do jogador, como o saldo atual de ouro e a adição de itens comprados.
* **ShopManager:** É o núcleo lógico. Valida se há ouro suficiente para a compra, deduz os valores e comunica o sucesso ou falha da operação.
* **UIManager:** Focado exclusivamente na interface de utilizador. Recebe ordens do ShopManager para atualizar os textos de ouro, adicionar itens ao _Scroll View_ do inventário e acionar os painéis e sons de aviso, mantendo a interface totalmente separada da lógica matemática do jogo.

##  Funcionalidades
* **Catálogo de Itens:** Exibição de itens com valores e sprites personalizados.
* **Sistema de Compra:** Validação de ouro e dedução automática do saldo do jogador.
* **Inventário Responsivo:** Lista rolável (Scroll View) que se adapta à quantidade de itens comprados.
* **Feedback Audiovisual:** Efeitos sonoros para compra e erro, além de mensagens visuais na tela usando texturas customizadas.
* **Interface Responsiva:** Ajuste automático de resolução (Canvas Scaler).

##  Tecnologias Utilizadas
* **Engine:** Unity 6000.3.11f1 (Unity 6.3)
* **Linguagem:** C#
* **UI:** TextMeshPro, Canvas, Layout Groups e Scroll View

##  Demonstração
<img width="1920" height="1034" alt="loja_theon" src="https://github.com/user-attachments/assets/52fcde5c-15dc-46a4-9497-cc53b814a069" />

