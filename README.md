# visma-edi
Class library for reading/writing visma edi files


```csharp
EdiPackage pack = new EdiPackage("123");

pack.Add(new Actor()
{
    CustNo = "1001",
    Nm = "Test company"
});

pack.Add(new Actor()
{
    CustNo = "1002",
    Nm = "Test company 2"
});

pack.SaveTo("test.edi");
```

Output

```
@FIRM_BEGIN(123)

@IMPORT_METHOD(1)
@String (=CustNo,Nm)
"1001","Test company"
"1002","Test company 2"

```
