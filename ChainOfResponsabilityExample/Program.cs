namespace ChainOfResponsabilityExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Approver andrei = new Director();
            Approver gelu = new VicePresident();
            Approver valentin = new President();

            andrei.SetSuccessor(gelu);
            gelu.SetSuccessor(valentin);

            var p = new Purchase(2034, 350.00, "Assets");
            andrei.ProcessRequest(p);

            p = new Purchase(2035, 32590.10, "Project X");
            andrei.ProcessRequest(p);

            p = new Purchase(2036, 122100.00, "Project Y");
            andrei.ProcessRequest(p);
        }
    }
}
