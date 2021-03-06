using System;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Xml.Linq;
using ExpressionSerialization;

[ServiceContract]
public interface INorthwindService
{
    [OperationContract]
    Customer[] ExecuteQueryForCustomers(XElement xml);
    [OperationContract]
    Order[] ExecuteQueryForOrders(XElement xml);
    [OperationContract]
    object[] ExecuteQueryForObjects(XElement xml);
    [OperationContract]
    Customer ExecuteQueryForCustomer(XElement xml);
    [OperationContract]
    Order ExecuteQueryForOrder(XElement xml);
    [OperationContract]
    object ExecuteQueryForObject(XElement xml);
}

public class NorthwindService : INorthwindService
{
    public Customer[] ExecuteQueryForCustomers(XElement xml)
    {
        NorthwindDataContext db = new NorthwindDataContext();
        IQueryable queryAfter = db.DeserializeQuery(xml);
        return queryAfter.Cast<Customer>().ToArray();
    }

    public Order[] ExecuteQueryForOrders(XElement xml)
    {
        NorthwindDataContext db = new NorthwindDataContext();
        IQueryable queryAfter = db.DeserializeQuery(xml);
        return queryAfter.Cast<Order>().ToArray();
    }

    public object[] ExecuteQueryForObjects(XElement xml)
    {
        NorthwindDataContext db = new NorthwindDataContext();
        IQueryable queryAfter = db.DeserializeQuery(xml);
        return queryAfter.Cast<object>().ToArray();
    }

    public Customer ExecuteQueryForCustomer(XElement xml)
    {
        NorthwindDataContext db = new NorthwindDataContext();
        IQueryable queryAfter = db.DeserializeQuery(xml);
        return (Customer)queryAfter.Provider.Execute(queryAfter.Expression);
    }

    public Order ExecuteQueryForOrder(XElement xml)
    {
        Debugger.Launch();
        NorthwindDataContext db = new NorthwindDataContext();
        IQueryable queryAfter = db.DeserializeQuery(xml);
        return (Order)queryAfter.Provider.Execute(queryAfter.Expression);
    }

    public object ExecuteQueryForObject(XElement xml)
    {
        NorthwindDataContext db = new NorthwindDataContext();
        IQueryable queryAfter = db.DeserializeQuery(xml);
        return queryAfter.Provider.Execute(queryAfter.Expression);
    }
}