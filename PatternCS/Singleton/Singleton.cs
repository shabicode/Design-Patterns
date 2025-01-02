public class Singleton {
    private static Singleton instance = null;
    public string msg = "";
    protected Singleton() {
        msg = "MochiLover";
    }
    public static Singleton Instance {
        get {   
            if (instance == null) {
                 instance = new Singleton();
            } 
            return instance;
        }
    }
}