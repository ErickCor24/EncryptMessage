using System.Runtime.InteropServices;

public class Program{
    public static void Main (string[] args){
        string? input = "";
        string messageEncrypt;
        string messageDecrypt;
        string? option;
        Console.Clear();
        Console.WriteLine("Insert the message: ");
        input = Console.ReadLine();
        messageEncrypt = encryptMessage(input);
        Console.WriteLine("Successful encryption");
        Console.WriteLine("Do you want to see the encrypt message? (Y/N)");
        option = Console.ReadLine();
        if(option.ToLower()=="y"){
            Console.WriteLine(messageEncrypt);
        }else{
            Console.WriteLine("Thanks!!!");
        }
        Console.WriteLine("Do you want to see the decrypt message? (Y/N)");
        option = Console.ReadLine();
        if(option.ToLower()=="y"){
            messageDecrypt = decryptMessage(messageEncrypt);
            Console.WriteLine(messageDecrypt);
        }else{
            Console.WriteLine("Thanks!!!");
        }
    }

    static string encryptMessage(string message){
        char [] letter = message.ToCharArray();
        Array.Reverse(letter);

        for( int i=0 ; i < letter.Length; i++){
            switch(letter[i]){
                case 'a':
                    letter[i] = '§';
                break;
                case 'e':
                    letter[i] = '▬';
                break;
                case 'i':
                    letter[i] = '>';
                break;
                case 'o':
                    letter[i] = 'À';
                break;
                case 'u':
                    letter[i] = '¦';
                break;
                case 'b':
                    letter[i] = '►';
                break;
                case 'l':
                    letter[i] = 'Í';
                break;
                case 's':
                    letter[i] = '¶';
                break;
                case ' ':
                    letter[i] = '_';
                break;
            }
        }
        message = new string(letter);
        return message;
    }

    static string decryptMessage(string message){
        char [] letter = message.ToCharArray();
        Array.Reverse(letter);

        for( int i=0 ; i < letter.Length; i++){
            switch(letter[i]){
                case '§':
                    letter[i] = 'a';
                break;
                case '▬':
                    letter[i] = 'e';
                break;
                case '>':
                    letter[i] = 'i';
                break;
                case 'À':
                    letter[i] = 'o';
                break;
                case '¦':
                    letter[i] = 'u';
                break;
                case '►':
                    letter[i] = 'b';
                break;
                case 'Í':
                    letter[i] = 'l';
                break;
                case '¶':
                    letter[i] = 's';
                break;
                case '_':
                    letter[i] = ' ';
                break;
            }
        }
        message = new string(letter);
        return message;
    }
}

