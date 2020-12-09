public struct ApiSetup<T>
    { }
class Api
{
    public ApiSetup<T> For<T>(T obj)
    {
        return new ApiSetup<T>();
    }
}
interface ISomeInterfaceA
{ }
interface ISomeInterfaceB
{ }
public class ObjectA : ISomeInterfaceA
{ }
public class ObjectB : ISomeInterfaceB
{ }


static class MyExtensionsApi
{
    public static ApiSetup<ObjectA> For(this Api api, ObjectA obj)
    {
        return api.For<ObjectA>(obj);
    }

    public static ApiSetup<ObjectB> For(this Api api, ObjectB obj)
    {
        return api.For<ObjectB>(obj);
    }
}


static class MyExtensionsObjectA
{
    public static void SetupObjectA(this ApiSetup<ObjectA> setup)
    { }
}

static class MyExtensionsObjectB
{
    public static void SetupObjectB(this ApiSetup<ObjectB> setup)
	{ }
}



class Program
{
    static void Main(string[] args)
    {
        Api apiObject = new Api();
        
        apiObject.For(new ObjectA()).SetupObjectA();
        apiObject.For(new ObjectB()).SetupObjectB();
    }
}