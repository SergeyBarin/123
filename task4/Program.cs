int Prompt(string message) {
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
bool IsWeekend (int weekday){
    if(weekday>5){
        return true;
    }
    return false;
}
bool ValidateWeekday(int number){
    if(number>0 && number<=7){
        return true;
    }
    Console.WriteLine("Это не день недели!");
    return false;
}
int weekday = Prompt("Введите день недели > ");
if(ValidateWeekday(weekday)){
    if(IsWeekend(weekday)){
        System.Console.WriteLine("Наконец-то выходной!");
    }
    else{
        System.Console.WriteLine("Работать, солнце еще стоит");
    }
}