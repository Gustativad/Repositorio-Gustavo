namespace WebTeste.Models
{
    public class Resultados
    {
        //Nesta classe estaria sendo armazenada a parte do código responsável pela exibição de algumas resoluções pedidas como (total de pontos, média por jogo, maior e menor pontuação e etc.).

        //Seguindo a instrução dada no documento do teste, deixarei as anotações sobre minha dificuldade com esta parte do código.

        //Primeiro tive um pouco de dificuldade em achar uma forma de como conseguir retirar informações especificas do banco de dados para exibir na tela.

        //O exemplo mais claro que posso citar seria o de pedir ao banco de dados que me retornasse somente os valores inseridos na coluna de "Inserir_Pontuação";
        //Logo após deveria executar a parte do código responsável por fazer a soma total dos valores inseridos, o que retornaria o valor total que deveria ser exibido para o usuário.

        //O mesmo problema se aplica aos demais resultados quando penso em retirar apenas os valores especificos que desejo para o resultado final.

        //A lógica por trás dos resultados não foi tão complicada de entender pois no próprio documento havia pequenas descrições sobre os resultados.

        //Assim como o total de pontos que deveria ser a soma de todos os valores.

        //A média de pontos por jogo que deveria conter o total da soma dos valores da pontução e seria divido pelo total de jogos disputados pelo usuário, assim retornaria a média de pontos por jogo.


        //Também senti um pouco de dificuldade para entender como poderia retirar o menor e o maior valor registrado nas pontuações.

        //A solução que cheguei a pensar para resolver a questão de puxar os valores do banco de dados, foi a de utilizar o comando "Select" do SQL para especificar os dados que eu desejava;
        //Porém não encontrei uma maneira de utilizar esse comando SQL dentro do código em C#, mesmo com as extensões do SQLServer adicionadas na máquina.

        //Também pensei na possibilidade de usar o sistema de Chave Estrangeira do banco de dados, porém estive na dúvida sobre a eficácia deste método;
        //Pois imaginei que para ter êxito na aplicação a chave estrangeira devesse ter sido criada junto do banco de dados lá no começo.

        //Estes foram os pontos que me incomodaram e me deram uma pequena dificuldade para finalizar o código.
    }
}
