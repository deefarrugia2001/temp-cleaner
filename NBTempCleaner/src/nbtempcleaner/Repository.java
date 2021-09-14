package nbtempcleaner;

/* Imported in order to access and create directories, as well as to fetch 
 * their respective sub-folders and prooeed with deletion. */
import java.io.File;

/* Repository has been declared abstract with the aim to simply contain members 
 * common to all classes representing folders containing temporary data. 
 * If one instantiates an object of Repository, the compiler will not know 
 * which folder to target for deletion. However, it is possible to instantiate 
 * an object of a type deriving from Repository and storing it in a variable 
 * of type Repository. Upon declaring Repository abstract, one will encounter
 * an error as objects of an abstract type cannot be instantiated. */
public abstract class Repository {
    String path; //Contains the absolute path to the folder containing temporary data.
    
    /* Used a getter to fetch the absolute path. A setter was not defined 
     * because we do not intend to change the path from the one defined 
     * in the constructors of the defined classes. */
    public String getPath() {
        return this.path; //Return the absolute path (this refers to the current class).
    }
}