Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel

Imports DevExpress.Xpo

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation
Imports DevExpress.ExpressApp.Reports
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.Data.Filtering
Imports DevExpress.ExpressApp.Xpo

Namespace DXSample.Module
	<NonPersistent> _
	Public Class CriteriaReportParametersObject
		Inherits ReportParametersObjectBase
		Public Sub New(ByVal objectSpace As IObjectSpace, ByVal reportDataType As Type)
			MyBase.New(objectSpace, reportDataType)
		End Sub

		Public Overrides Function GetCriteria() As DevExpress.Data.Filtering.CriteriaOperator
			Return CriteriaEditorHelper.GetCriteriaOperator(Criteria, ReportDataType, ObjectSpace)
		End Function

		Public Overrides Function GetSorting() As SortProperty()
			Return New SortProperty(){}
		End Function

		Private _Criteria As String
		<CriteriaOptions("ReportDataType"), Size(SizeAttribute.Unlimited)> _
		Public Property Criteria() As String
			Get
				Return _Criteria
			End Get
			Set(ByVal value As String)
				_Criteria = value
			End Set
		End Property
	End Class
End Namespace
