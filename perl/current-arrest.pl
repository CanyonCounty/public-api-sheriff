#!/usr/bin/env perl

# Written for perl 5.x
# My perl is five years rusty - apologies to Monks out there
# Tested on
# Ubuntu 14.04 LTS (trusty) - perl (v5.18.2)

use strict;
use warnings;

use JSON;        # cpan JSON
use LWP::Simple; #cpan LWP::Simple

# get the arrest data
my $data = get("http://api.canyonco.org/Sheriff/CurrentArrest");
die "Couldn't get it!" unless defined $data;

# parse the JSON
my $json = JSON->new->allow_nonref;
my $inmates = $json->decode($data);
my $error = "The error was...";

# loop through the inmates
foreach my $inmate(@{$inmates}) {
  
    # If the first element's Error is not empty it will be the error message
    # not exactly restful, but it was easy
  $error = $inmate->{Error}; 
  last if $error ne "";
  
  print "$inmate->{LastName}, $inmate->{FirstName} $inmate->{MiddleName}\n";

  # loop through the arrests
  foreach my $arrest(@{$inmate->{Arrests}}) {
    print "  Arrest Date: $arrest->{ArrestDate}\n";
  }

  # loop through the charges
  foreach my $charge(@{$inmate->{Charges}}) {
    print "  Charge: $charge->{StatuteCode}: $charge->{StatuteDesc}\n";
  }
}

# if error was set - display it
print "Error: $error\n" if $error ne "";
