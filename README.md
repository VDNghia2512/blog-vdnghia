# blog-vdnghia

[Download_Git-SCM]
https://git-scm.com/

[git_clone_link]
https://github.com/VDNghia2512/blog-vdnghia

[Visual_version]
1.17.2

[dotnet_version]
6.0.402

[install_dotnet-ef]
dotnet tool install --global dotnet-ef

<!-- dotnet restore -->

[Add_folder_Migrations]
<!-- Nếu chưa có folder Migrations-->
dotnet ef migrations add Migrations

[Build_Project]
dotnet build

[database_update]
dotnet ef database update

[Run_project]
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


[Body postman]
{
"DisplayName":"Vo Dai Nghia",
"Email" : "vdnghia2512@gmail.com",
"Phone" :"0359715163"
}