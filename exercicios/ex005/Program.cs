class ex005{
    public static void Main ()
    {
        //chamar método
        ListaDoChurrasco();
    }


    public static void ListaDoChurrasco(){
        //declarar o vetor com 6 posiçoes tipo string 
        string[] listaProdutos = new string[6];

        //receber os produtos que precisam ser comprados
        listaProdutos[0] = "carne 3kg";
        for (int i = 0; i < listaProdutos.Length; i ++)
        {
            Console.WriteLine("Informe o produto:");
            string produto = Console.ReadLine();
            listaProdutos[i] = produto;            
        }
        
        //ordenar vetor 
        Array.Sort(listaProdutos);

        //"para cada" item na lista exibir no console 
        foreach (string Item in listaProdutos){
            Console.WriteLine($"Item {Item}");
        }
    }
}
