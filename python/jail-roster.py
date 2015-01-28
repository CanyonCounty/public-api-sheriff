#!/usr/bin/env python

# Written for Python 2.x
# Tested on
# Windows 7 x64 - Python 2.7.6

import urllib
import json

if __name__ == "__main__":
  # get the arrest data
  roster = urllib.urlopen("http://api.canyonco.org/Sheriff-Beta/JailRosterByLetter/A").read()
  # parse the JSON
  jsonData = json.loads(roster)

  # If the first element's Error is not empty it will be the error message
  # not exactly restful, but it was easy
  error = jsonData[0]["Error"]

  if error == '':
    # loop through the inmates
    for inmate in jsonData:
      print "%s, %s" % (inmate["LastName"].title(), inmate["FirstName"].title())

      # loop through the arrests
      for arrest in inmate["Arrests"]:
        print "  Arrest Date: %s" % arrest["ArrestDate"]

      # loop through the charges
      for charge in inmate["Charges"]:
        print "  Charge: %s: %s" % (charge["StatuteCode"], charge["StatuteDesc"])

  else:
    print "Error getting data", error