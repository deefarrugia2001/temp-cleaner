/* extends denotes that WindowsTemp can now access members belonging to Repository. 
 * final denotes that classes cannot derive from this class, hence it can NEVER be a base class. */
public class WindowsTemp extends Repository {
    public WindowsTemp() {
        this.path = "C:\\Windows\\Temp";
    }
}