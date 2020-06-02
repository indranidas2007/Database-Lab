Public Class adminviewvb
    Private Sub adminviewvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UnicounsellingDataSet6.student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.UnicounsellingDataSet6.student)
        'TODO: This line of code loads data into the 'UnicounsellingDataSet5.address' table. You can move, or remove it, as needed.
        Me.AddressTableAdapter.Fill(Me.UnicounsellingDataSet5.address)
        'TODO: This line of code loads data into the 'UnicounsellingDataSet4.admission_details' table. You can move, or remove it, as needed.
        Me.Admission_detailsTableAdapter.Fill(Me.UnicounsellingDataSet4.admission_details)
        'TODO: This line of code loads data into the 'UnicounsellingDataSet2.payment_details' table. You can move, or remove it, as needed.
        Me.Payment_detailsTableAdapter.Fill(Me.UnicounsellingDataSet2.payment_details)

    End Sub
End Class