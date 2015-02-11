import java.io.*;
import java.net.*;

// using the json-simple.jar file
import org.json.simple.*;
import org.json.simple.parser.*;

public class CurrentArrest {

  public static String getJSON(String urlToRead) {
    URL url;
    HttpURLConnection conn;
    BufferedReader rd;
    String line;
    String result = "";
    try {
      url = new URL(urlToRead);
      conn = (HttpURLConnection) url.openConnection();
      conn.setRequestMethod("GET");
      rd = new BufferedReader(new InputStreamReader(conn.getInputStream()));
      while ((line = rd.readLine()) != null) {
        result += line;
      }
      rd.close();
    } catch (IOException e) {
       e.printStackTrace();
    } catch (Exception e) {
       e.printStackTrace();
    }
    return result;
  }

  public static void main(String [] args) {
    String json = getJSON("http://api.canyonco.org/Sheriff/CurrentArrest");

    JSONParser parser = new JSONParser();
    try {
      Object obj = parser.parse(json);
      JSONArray array = (JSONArray)obj;
      //System.out.println(array.size());

      // Loop through the inmates
      for(int i = 0; i < array.size(); i++) {
        //System.out.println(array.get(i));
        JSONObject inmate = (JSONObject)array.get(i);
        System.out.printf("%s, %s %s\n", inmate.get("LastName"), inmate.get("FirstName"), inmate.get("MiddleName"));
        
        // Loop through the arrests
        JSONArray arrests = (JSONArray)inmate.get("Arrests");
        for (int a = 0; a < arrests.size(); a++) {
          JSONObject arrest = (JSONObject)arrests.get(a);
          System.out.printf("  Arrest Date: %s\n", arrest.get("ArrestDate"));
        }

        JSONArray charges = (JSONArray)inmate.get("Charges");
        for (int c = 0; c < charges.size(); c++) {
          JSONObject charge = (JSONObject)charges.get(c);
          System.out.printf("  Charge: %s: %s\n", charge.get("StatuteCode"), charge.get("StatuteDesc")); 
        }
        
        //break; // used to only print one record
      }

    } catch (ParseException pe) {
      pe.printStackTrace();
    }
  }  
}