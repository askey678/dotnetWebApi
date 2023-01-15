namespace BOL;

public class Department{
    public int id{get; set;}
    public int d_no{get; set;}
    public string d_name{get; set;}
    public double balance{get; set;}

    
    public static int static_id=1000;

    public Department(){
    }
    public Department(int num, string name, double bal){
        this.d_no=num;
        this.d_name=name;
        this.balance=bal;
        this.id=static_id;
    }
}