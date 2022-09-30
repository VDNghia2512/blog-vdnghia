# blog-vdnghia

Download Git-SCM | https://git-scm.com/
git clone  |https://github.com/VDNghia2512/blog-vdnghia

dotnet tool install --global dotnet-ef
dotnet restore

dotnet build
dotnet ef migrations add Migrations
dotnet ef database update
dotnet run
