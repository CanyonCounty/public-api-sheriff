open System;
open System.Collections.Generic;
open SheriffExampleDAL;

let inmates: List<Inmate> = Sheriff.GetCurrentArrests()

for inmate in inmates do
  Console.Out.WriteLine(String.Format("Name: {0}, {1} {2}", inmate.LastName, inmate.FirstName, inmate.MiddleName))
  for arrest in inmate.Arrests do
    Console.Out.WriteLine(String.Format("  Arrest: {0}", arrest.ArrestDate))
  for charge in inmate.Charges do
    Console.Out.WriteLine(String.Format("  Charge: {0}: {1}", charge.StatuteCode, charge.StatuteDesc))

Console.ReadKey() |> ignore
