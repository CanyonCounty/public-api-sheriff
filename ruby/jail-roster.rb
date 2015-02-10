#!/usr/bin/env ruby

# Written for Ruby 1.9.x
# Tested on
# Windows 7 x64 - Ruby 1.9.3
# Ubuntu 14.04 LTS (trusty) - Ruby 1.9.3

require 'open-uri'
require 'json'

# get the and parse the arrest data
jsonData = JSON.parse(open("http://api.canyonco.org/Sheriff/JailRosterByLetter/A").read)

# If the first element's Error is not empty it will be the error message
# not exactly restful, but it was easy
if jsonData[0]["Error"].empty?
  
  # loop through the inmates
  jsonData.each do |inmate|
    puts "#{inmate["LastName"].capitalize}, #{inmate["FirstName"].capitalize}"

    # loop through the arrests
    inmate["Arrests"].each do |arrest|
      puts "  Arrest Date: #{arrest["ArrestDate"]}"
    end
    
    # loop through the charges
    inmate["Charges"].each do |charge|
      puts "  Charge: #{charge["StatuteCode"]}: #{charge["StatuteDesc"]}"
    end
  end
else
  puts "Error: " + jsonData[0]["Error"]
end