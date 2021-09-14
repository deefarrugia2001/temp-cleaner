/* extends denotes that Prefetch can now access members belonging to Repository. 
 * final denotes that classes cannot derive from this class, hence it can NEVER be a base class. */
public final class Prefetch extends Repository {
  public Prefetch() {
      this.path = "C:\\Windows\\prefetch"; //When instantiating an object of Prefetch, said path will be assigned.
  }  
}