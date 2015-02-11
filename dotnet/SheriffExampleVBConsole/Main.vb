Imports SheriffExampleDAL

Module Main

  Sub Main()
    Dim list As List(Of Inmate) = Sheriff.GetCurrentArrests()
    If list(0).Error = "" Then
      For Each inmate As Inmate In list
        Console.Out.WriteLine(String.Format("Name: {0}, {1} {2}", inmate.LastName, inmate.FirstName, inmate.MiddleName))

        For Each arrest As Arrest In inmate.Arrests
          Console.Out.WriteLine(String.Format("  Arrest: {0}", arrest.ArrestDate))
        Next

        For Each Charge As Charge In inmate.Charges
          Console.Out.WriteLine(String.Format("  Charge: {0}: {1}", Charge.StatuteCode, Charge.StatuteDesc))
        Next
      Next

      Console.WriteLine("Press Any Key to Continue")
      Console.ReadKey()
    Else
      Console.WriteLine("Error: " & list(0).Error)
    End If
  End Sub

End Module
