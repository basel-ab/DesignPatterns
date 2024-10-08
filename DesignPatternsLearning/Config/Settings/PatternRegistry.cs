namespace DesignPatternsLearning.Config
{
    public static class PatternRegistry
    {
        private static readonly Dictionary<string, IPattern> Patterns = new Dictionary<string, IPattern>
        {
            { "1", new SingletonPattern() },
            { "2", new FactoryMethodPattern() },
            { "3", new FacadePattern() },
            { "4", new AdapterPattern() },
            { "5", new CompositePattern() },
            { "6", new ProxyPattern() },
            { "7", new DecoratorPattern() },
            { "8", new TemplatePattern() },
            { "9", new ChainOfResponsibilityPattern() },
            { "10", new StatePattern() },
            { "11", new CommandPattern() },
            { "12", new MediatorPattern() },
            { "13", new ObserverPattern() },
            { "14", new LSPPrinciple() },
            { "15", new OpenClosePrinciple() },
            { "16", new DependencyInversionPrinciple() },
            { "17", new InterfaceSegregationPrinciple() },
            { "18", new LeastKnowledgePrinciple() },
        };

        public static IPattern? GetPattern(string? choice)
        {
            if (choice != null && Patterns.ContainsKey(choice))
            {
                return Patterns[choice];
            }

            return null;
        }

        public static void ListPatterns()
        {
            Console.WriteLine("Choose a design pattern to test:");
            Console.WriteLine("----Creational Patterns----");
            Console.WriteLine("1. Singleton");
            Console.WriteLine("2. Factory Method");
            Console.WriteLine("----Structural Patterns----");
            Console.WriteLine("3. Facade");
            Console.WriteLine("4. Adapter");
            Console.WriteLine("5. Composite");
            Console.WriteLine("6. Proxy");
            Console.WriteLine("7. Decorator");
            Console.WriteLine("----Behavioral Patterns----");
            Console.WriteLine("8. Template");
            Console.WriteLine("9. Chain of Responsibility");
            Console.WriteLine("10. State");
            Console.WriteLine("11. Command");
            Console.WriteLine("12. Mediator");
            Console.WriteLine("13. Observer");
            Console.WriteLine("----Design Principles----");
            Console.WriteLine("14. LSP");
            Console.WriteLine("15. OpenClose");
            Console.WriteLine("16. Dependency Inversion");
            Console.WriteLine("17. Interface Segregation");
            Console.WriteLine("18. Least Knowledge");
        }
    }
}
