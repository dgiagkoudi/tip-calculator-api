# Tip Calculator API (ASP.NET Core)
Ένα απλό ASP.NET Core Web API που λειτουργεί ως backend για την εφαρμογή Tip Calculator (Angular).
Παρέχει endpoint για τον υπολογισμό φιλοδωρήματος και συνολικού ποσού ανά άτομο.

## Περιγραφή

Το API δέχεται δεδομένα λογαριασμού (bill amount, tip percentage, number of people)
και επιστρέφει:
- το φιλοδώρημα ανά άτομο
- το συνολικό ποσό ανά άτομο

Το project έχει σχεδιαστεί ώστε να καταναλώνεται από frontend εφαρμογή (Angular) μέσω HTTP requests και δεν περιλαμβάνει UI.

## Τεχνολογίες που χρησιμοποιήθηκαν
- ASP.NET Core 8
- C#
- RESTful Web API
- Swagger
- Dependency Injection

## Δομή φακέλων
```text
TipCalculatorAPI
├── Controllers/
│   └── TipController.ts
├── Models/
│   ├── TipRequest.cs
│   └── TipResponse.cs
├── Services/
│   ├── ITipCalculatorService.cs
│   └── TipCalculatorService.cs
├── Program.cs
└── TipCalculatorAPI.http
```

## Τοπική εκτέλεση
1. Κλωνοποιήστε το repository
2. Ανοίξτε το project στο Visual Studio 2022
3. Τρέξτε το project (Run)

Το API θα είναι διαθέσιμο στο: http://localhost:5048

Το Swagger UI: http://localhost:5048/swagger
