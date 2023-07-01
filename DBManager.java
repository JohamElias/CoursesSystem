package pe.edu.pucp.cinemasoft.config;
import java.sql.Connection;
import java.sql.DriverManager;
public class DBManager {
    private static DBManager dbManager;
    /* Colocar su nombre y código */
    /* Colocar la url de conexión */
    private String url = "jdbc:mysql://" +
            "lab3-lp2-2022-2.cffpkdxvkd7h.us-east-1.rds.amazonaws.com" +
            ":3306/test?useSSL=false";
    private String user = "administrador";
    private String password = "20222lp2";
    private Connection con;
    
    private synchronized static void createInstance(){
        if(dbManager == null){
            dbManager = new DBManager();
        }
    }
    
    public Connection getConnection(){
        try{
            //Registrar el Driver (ensamblado) de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(url,user,password);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return con;
    }
    
    public static DBManager getInstance(){
        if(dbManager == null){
            createInstance();
        }
        return dbManager;
    }
}