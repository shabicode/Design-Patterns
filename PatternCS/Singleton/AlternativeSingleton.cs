public sealed class AlternativeSingleton{
    //Custom Delegate
    delegate AlternativeSingleton SingletonDelegateWithNoParameter();
    static SingletonDelegateWithNoParameter myDel = MakeSingletonInstance;

    //Using built-in Func<out TResult> delegate
    static Func<AlternativeSingleton> myFuncDelegate = MakeSingletonInstance;
    private static readonly Lazy<AlternativeSingleton> Instance = new Lazy<AlternativeSingleton>(
        myDel() //using custom delegate
    );
    private static AlternativeSingleton MakeSingletonInstance() {
        return new AlternativeSingleton();
    }
    private AlternativeSingleton() {}
    public static AlternativeSingleton GetInstance {
        get { return Instance.Value; }
    }
}