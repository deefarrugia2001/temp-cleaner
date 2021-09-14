import java.io.File; //Imported in order to access and create directories, as well as to fetch their respective sub-folders and prooeed with deletion.

/* Repository has been declared abstract with the aim to simply contain members common to all classes representing folders containing temporary data. 
 * If one instantiates an object of Repository, the compiler will not know which folder to target for deletion. However, it is possible to 
 * instantiate an object of a type deriving from Repository and storing it in a variable of type Repository. Upon declaring Repository abstract, 
 * one will encounter an error as objects of an abstract type cannot be instantiated. */
public abstract class Repository {
    String path; //Contains the absolute path to the folder containing temporary data.
    
    //Used a getter to fetch the absolute path. (Setter not defined since the path within the constructors of the derived classes will never change).
    public String getPath() {
        return this.path; //Return the absolute path (this refers to the current class).
    }
    
    public void delete() {
        File folder = new File(this.path); //Access the directory based on the given path.
        File[] files = folder.listFiles(); //Fetch all content in the directory.
        
        for(File file : files) { //Iterate through file within the directory.
            File[] subDirectories = file.listFiles(); //Locate any subfolders and include them in the array.
            if(subDirectories != null) { //If there is at least a single subfolder, then proceed with the deletion of the subfiles.
                for(File subFiles : subDirectories) //Access all data within the subfolders.
                    subFiles.delete(); //Delete all subfiles.
            }
            
            file.delete(); //Delete all files within the parent folder.
        }
    }
}