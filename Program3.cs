Yes, we can create a class with a private constructor in Java
class PrivateConstructorExample {
    private String message;

    private PrivateConstructorExample(String message) {
        this.message = message;
  
    public static PrivateConstructorExample createInstance(String message) {
        return new PrivateConstructorExample(message);
    }

    public String getMessage() {
        return message;
    }

    public void setMessage(String message) {
        this.message = message;
    }
}

public class Main {
    public static void main(String[] args) {
        PrivateConstructorExample instance = 
        System.out.println("Message: " + instance.getMessage()); // Output: Hello, World!
        class PrivateConstructorExample {
    private String message;

    private PrivateConstructorExample(String message) {
        this.message = message;
  
    public static PrivateConstructorExample createInstance(String message) {
        return new PrivateConstructorExample(message);
    }
    public String getMessage() {
        return message;
    }

    public void setMessage(String message) {
        this.message = message;
    }
}

public class Main {
    public static void main(String[] args) {
        PrivateConstructorExample instance = PrivateConstructorExample.createInstance("Hello, World!");
        System.out.println("Message: " + instance.getMessage()); // Output: Hello, World!
        
        instance.setMessage("Updated Message");
        System.out.println("Updated Message: " + instance.getMessage()); // Output: Updated Message
    }
}

        instance.setMessage("Updated Message");
        System.out.println("Updated Message: " + instance.getMessage()); // Output: Updated Message
    }
}
