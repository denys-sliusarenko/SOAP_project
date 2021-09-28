# SOAP_project
SOAP API example


TestMethod Request

```xml
<?xml version="1.0" encoding="utf-8"?>
<soap:Envelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/">
  <soap:Body>
  <Test xmlns="http://tempuri.org/">
      <s>This is Test String</s>
    </Test>
  </soap:Body>
</soap:Envelope>
```

TestUserModel Request

```xml
<?xml version="1.0" encoding="utf-8"?>
<soap:Envelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/">
  <soap:Body>
    <TestUserModel xmlns="http://tempuri.org/">
    <model>
       <Id>3</Id>
       <Name>UserName</Name>
    </model>
    </TestUserModel>
  </soap:Body>
</soap:Envelope>
```
