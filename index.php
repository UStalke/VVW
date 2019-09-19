
<!doctype html>
<html lang="de">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>neues Mitglied</title>
  </head>
  <body>
    <table>
      <tr>
        <td> Anrede: </td>
        <td>
            <select name="Anrede">
              <option selected> Herr </option>
              <option> Frau </option>
            </select>

        </td>
      </tr>
      <tr>
        <td> Anredezusatz: </td>
        <td>
          <input type="text"/>
        </td>
      </tr>
      <tr>
        <td> Vorname: </td>
        <td>
          <input type="text"/>
        </td>
      </tr>
      <tr>
        <td> Nachname: </td>
        <td>
          <input type="text"/>
        </td>
      </tr>
      <tr>
        <td> Straße: </td>
        <td>
          <input type="text"/>
        </td>
      </tr>
      <tr>
        <td> Hausnummer: </td>
        <td>
          <input type="text"/>
        </td>
      </tr>
      <tr>
        <td> PLZ: </td>
        <td>
          <input type="text"/>
        </td>
      </tr>
      <tr>
        <td> Ort: </td>
        <td>
          <input type="text"/>
        </td>
      </tr>
      <tr>
        <td> Geburtsort: </td>
        <td>
          <input type="text"/>
        </td>
      </tr>
      <tr>
        <td> Telefon: </td>
        <td>
          <input type="text"/>
        </td>
      </tr>
      <tr>
        <td> E-mail: </td>
        <td>
          <input type="text"/>
        </td>
      </tr>
      <tr>
        <td> Konfektionsgröße: <?php echo "hallo Welt"; ?></td>
        <td>

          <select name="Konfektionsgröße">
            <option  value="1"> XS </option>
            <option value="2"> S </option>
            <option value="3" selected> M </option>
            <option value="4"> L </option>
            <option value="5"> XL </option>
          </select><br/>

        </td>
      </tr>
      <tr>
        <td colspan="2">
          <button name="btn" value="send"> absenden </button>


        </td>
      </tr>
    </table>




  </body>
</html>
