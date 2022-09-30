# blog-vdnghia

Download Git-SCM | https://git-scm.com/
git clone  |https://github.com/VDNghia2512/blog-vdnghia
[dotnet]

dotnet tool install --global dotnet-ef
dotnet restore

dotnet build
dotnet ef migrations add Migrations
dotnet ef database update
dotnet run

[git]
git config --global user.email "user@gmail.com"

git config --global user.name "username"
git add .
git commit -m "Initial commit"
git remote
git push

[HTTP]
http://localhost:5114/api/user