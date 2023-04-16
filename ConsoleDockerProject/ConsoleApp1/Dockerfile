#Docker.hub tan bir image almamýzý saðlar. Yani Image yüklememizi saðlar. Çünkü console uygulamasýný bu image üzerind çalýþtýrýlacak.
FROM mcr.microsoft.com/dotnet/runtime:6.0
#Çalýþma klasörü oluþturma komutu
WORKDIR /App
#ilk route daki klasörlei, app klasörüne kopyala
COPY bin/Release/net6.0/publish app/
#Bir image dan container ayaða kalktýðý zaman çalýþacak olan kodu belirler, 
ENTRYPOINT ["dotnet","ConsoleDocker.dll"]
