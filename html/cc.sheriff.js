function loadCanyonCountyData(url) {
// Send an AJAX request
$.getJSON(url, function (data) {
    // for each result build the table
    // TODO: use the jQuery functions for building html elements
    $.each(data, function (key, val) {
      var str = "<td>" + val.IDNumber + "</td>";
      str += "<td><strong>" + val.LastName + ", " + val.FirstName + "</strong><br />" +val.VineLink+ "</td>";

      var arrests = val.Arrests;

      str += "<td><table class='arrest' width='100%'>";
      $.each(val.Arrests, function (k, v) {

        str += "<tr><td>" + v.ArrestDate + "</td></tr>";
      });

      str += "</table></td>";

      var charges = val.Charges;

      str += "<td><table class='charge' width='100%'>";
      $.each(charges, function (k, v) {

        str += "<tr><td>" + v.StatuteCode + "</td><td>" + v.StatuteDesc + "</td></tr>";
      });

      str += "</table></td>";

      str += "<td><a href='" + val.ImageFull + "' alt='View Larger'><img src='"+ val.ImageThumb+"'></a></td>";

      str += "</tr>";

      $('<tr>', { html: str }).appendTo($('#current'));
    });
  });
}