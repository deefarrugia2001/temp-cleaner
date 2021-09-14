package nbtempcleaner;

import com.sun.security.auth.module.NTSystem;

/* Please note that this only deletes the %temp% content of the currently logged in user!
 * extends denotes that UserTemp can now access members belonging to Repository. 
 * final denotes that classes cannot derive from this class, hence it can NEVER be a base class. */
public final class UserTemp extends Repository {
    public UserTemp() {
        this.path = "C:\\Users\\" + new NTSystem().getName() + "\\AppData\\Local\\Temp";
    }
}