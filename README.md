# 设计模式

设计模式（Design pattern）代表了最佳的实践，通常被有经验的面向对象的软件开发人员所采用。设计模式是软件开发人员在软件开发过程中面临的一般问题的解决方案。这些解决方案是众多软件开发人员经过相当长的一段时间的试验和错误总结出来的。

本教程将通过 C# .Net Core 实例，一步一步向您讲解设计模式的概念。

>[创建型模式（Creational Patterns）](https://github.com/qq550723504/DesignPatterns/tree/master/CreationalPatterns)
>
> + [工厂模式（Factory Pattern](https://github.com/qq550723504/DesignPatterns/tree/master/CreationalPatterns/FactoryPattern)
> + [抽象工厂模式（Abstract Factory Pattern）](https://github.com/qq550723504/DesignPatterns/tree/master/CreationalPatterns/AbstractFactoryPattern)
> + [单例模式（Singleton Pattern）](https://github.com/qq550723504/DesignPatterns/tree/master/CreationalPatterns/SingletonPattern)
> + [建造者模式（Builder Pattern）](https://github.com/qq550723504/DesignPatterns/tree/master/CreationalPatterns/BuilderPattern)
> + [原型模式（Prototype Pattern）](https://github.com/qq550723504/DesignPatterns/tree/master/CreationalPatterns/PrototypePattern)
>
>[结构型模式（Structural Patterns）](https://github.com/qq550723504/DesignPatterns/tree/master/StructuralPatterns)
>
> + [适配器模式（Adapter Pattern）](https://github.com/qq550723504/DesignPatterns/tree/master/StructuralPatterns/AdapterPattern)
> + [桥接模式（Bridge Pattern）](https://github.com/qq550723504/DesignPatterns/tree/master/StructuralPatterns/BridgePattern)
> + [过滤器模式（Filter、Criteria Pattern）](https://github.com/qq550723504/DesignPatterns/tree/master/StructuralPatterns/FilterPattern)
> + [组合模式（Composite Pattern）](https://github.com/qq550723504/DesignPatterns/tree/master/StructuralPatterns/CompositePattern)
> + [装饰器模式（Decorator Pattern）](https://github.com/qq550723504/DesignPatterns/tree/master/StructuralPatterns/DecoratorPattern)
> + [外观模式（Facade Pattern）](https://github.com/qq550723504/DesignPatterns/tree/master/StructuralPatterns/FacadePattern)
> + [享元模式（Flyweight Pattern）](https://github.com/qq550723504/DesignPatterns/tree/master/StructuralPatterns/FlyweightPattern)
> + [代理模式（Proxy Pattern）](https://github.com/qq550723504/DesignPatterns/tree/master/StructuralPatterns/ProxyPattern)
>
>[行为型模式（Behavioral Patterns）](https://github.com/qq550723504/DesignPatterns/tree/master/BehavioralPatterns)
>
> + [责任链模式（Chain of Responsibility Pattern）](https://github.com/qq550723504/DesignPatterns/tree/master/BehavioralPatterns/ChainOfResponsibilityPattern)
> + [命令模式（Command Pattern）](https://github.com/qq550723504/DesignPatterns/tree/master/BehavioralPatterns/CommandPattern)
> + [解释器模式（Interpreter Pattern）](https://github.com/qq550723504/DesignPatterns/tree/master/BehavioralPatterns/InterpreterPattern)
> + [迭代器模式（Iterator Pattern）](https://github.com/qq550723504/DesignPatterns/tree/master/BehavioralPatterns/IteratorPattern)
> + [中介者模式（Mediator Pattern）](https://github.com/qq550723504/DesignPatterns/tree/master/BehavioralPatterns/MediatorPattern)
> + [备忘录模式（Memento Pattern）](https://github.com/qq550723504/DesignPatterns/tree/master/BehavioralPatterns/MementoPattern)
> + [观察者模式（Observer Pattern）](https://github.com/qq550723504/DesignPatterns/tree/master/BehavioralPatterns/ObserverPattern)
> + [状态模式（State Pattern）](https://github.com/qq550723504/DesignPatterns/tree/master/BehavioralPatterns/StatePattern)
> + [空对象模式（Null Object Pattern）](https://github.com/qq550723504/DesignPatterns/tree/master/BehavioralPatterns/NullObjectPattern)
> + [策略模式（Strategy Pattern）](https://github.com/qq550723504/DesignPatterns/tree/master/BehavioralPatterns/StrategyPattern)
> + [模板模式（Template Pattern）](https://github.com/qq550723504/DesignPatterns/tree/master/BehavioralPatterns/TemplatePattern)
> + [访问者模式（Visitor Pattern）](https://github.com/qq550723504/DesignPatterns/tree/master/BehavioralPatterns/VisitorPattern)
>

## 设计模式的六大原则

1.开闭原则（Open Close Principle）

开闭原则的意思是：对扩展开放，对修改关闭。在程序需要进行拓展的时候，不能去修改原有的代码，实现一个热插拔的效果。简言之，是为了使程序的扩展性好，易于维护和升级。想要达到这样的效果，我们需要使用接口和抽象类，后面的具体设计中我们会提到这点。

2.里氏代换原则（Liskov Substitution Principle）

里氏代换原则是面向对象设计的基本原则之一。 里氏代换原则中说，任何基类可以出现的地方，子类一定可以出现。LSP 是继承复用的基石，只有当派生类可以替换掉基类，且软件单位的功能不受到影响时，基类才能真正被复用，而派生类也能够在基类的基础上增加新的行为。里氏代换原则是对开闭原则的补充。实现开闭原则的关键步骤就是抽象化，而基类与子类的继承关系就是抽象化的具体实现，所以里氏代换原则是对实现抽象化的具体步骤的规范。

3.依赖倒转原则（Dependence Inversion Principle）

这个原则是开闭原则的基础，具体内容：针对接口编程，依赖于抽象而不依赖于具体。

4.接口隔离原则（Interface Segregation Principle）

这个原则的意思是：使用多个隔离的接口，比使用单个接口要好。它还有另外一个意思是：降低类之间的耦合度。由此可见，其实设计模式就是从大型软件架构出发、便于升级和维护的软件设计思想，它强调降低依赖，降低耦合。

5.迪米特法则，又称最少知道原则（Demeter Principle）

最少知道原则是指：一个实体应当尽量少地与其他实体之间发生相互作用，使得系统功能模块相对独立。

6.合成复用原则（Composite Reuse Principle）

合成复用原则是指：尽量使用合成/聚合的方式，而不是使用继承。

## 谁适合阅读本教程

无论您是新手，还是老手，本教程都值得一读。对于那些具有丰富的开发经验的开发人员，学习设计模式有助于了解在软件开发过程中所面临的问题的最佳解决方案；对于那些经验不足的开发人员，学习设计模式有助于通过一种简单快捷的方式来学习软件设计。

## 阅读本教程前，您需要了解的知识

在您开始阅读本教程之前，您必须具备基本的 C# 编程的概念。如果您还不了解这些概念
