package nbtempcleaner;

/* Repository has been declared abstract with the aim to simply contain members 
 * common to all classes representing folders containing temporary data. 
 * If one instantiates an object of Repository, the compiler will not know 
 * which folder to target for deletion. However, it is possible to instantiate 
 * an object of a type deriving from Repository and storing it in a variable 
 * of type Repository. Upon declaring Repository abstract, one will encounter
 * an error as objects of an abstract type cannot be instantiated. */
public abstract class Repository {
    
}