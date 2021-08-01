Проект работает как апи с единственной точкой входа , которой является POST метод.
После того как приходит информация для пополнения баланса, сервер отправляет запрос на handler который его ловит и производит пополнение баланса с помощью сервиса 
который сам определяет нужного оператора по входным данным. 
Логгирование было сделано с помощью Azure Application Insights. Не большой минус в том что конкретно в ажур портале не выводится логгируемый message из за того что данные 
отправляются с помощью локального IIS Express.

Пример запроса: 
url - http://localhost:48009/MobileBalance

json данные 
{
    "PhoneNumber" : "87770261384",
    "Amount" : 100,
    "OperatorType" : 3
}

![Image alt](https://github.com/Leloporopoka/MobileBalanceTopUp/raw/master/image1.jpg)
![Image alt](https://github.com/Leloporopoka/MobileBalanceTopUp/raw/master/image2.jpg)
