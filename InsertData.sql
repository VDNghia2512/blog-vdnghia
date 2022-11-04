USE [BlogDB]
GO
INSERT [dbo].[tblUser] ([ID], [DisplayName], [Email], [Phone], [DateOfBirth], [Address], [CreateAt], [UpdateAt]) VALUES (N'ae2f469b-4b50-4811-8726-174832b16f8a', N'Đạt', N'nekoma@gmail.com', N'661262612114', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'Tây Ninh', CAST(N'2022-11-04T06:41:26.2753400' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[tblUser] ([ID], [DisplayName], [Email], [Phone], [DateOfBirth], [Address], [CreateAt], [UpdateAt]) VALUES (N'930fbd18-6183-4455-8f06-3100fce759ed', N'Vo Dai Nghia', N'vdnghia2512@gmail.com', N'0359715163', CAST(N'2001-12-25T00:00:00.0000000' AS DateTime2), N'An Giang', CAST(N'2022-11-02T01:16:35.0170645' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[tblUser] ([ID], [DisplayName], [Email], [Phone], [DateOfBirth], [Address], [CreateAt], [UpdateAt]) VALUES (N'273f2176-3324-473d-8ea6-6ad987936b9c', N'Triết', N'triet@gmail.com', N'1312312981', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'Bình Dương', CAST(N'2022-11-04T06:40:40.5152296' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[tblUser] ([ID], [DisplayName], [Email], [Phone], [DateOfBirth], [Address], [CreateAt], [UpdateAt]) VALUES (N'da9b2051-f0f8-4458-bbe9-7c93afa65068', N'Huy', N'Huy@gmail.com', N'12847612', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'Hà Nội', CAST(N'2022-11-04T06:41:52.9158809' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[tblUser] ([ID], [DisplayName], [Email], [Phone], [DateOfBirth], [Address], [CreateAt], [UpdateAt]) VALUES (N'492decad-12f2-40dd-a2d5-bee32f1845bf', N'Triệu', N'trieu@gmail.com', N'123123123', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'binh duong', CAST(N'2022-11-03T09:41:17.9918807' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[tblUser] ([ID], [DisplayName], [Email], [Phone], [DateOfBirth], [Address], [CreateAt], [UpdateAt]) VALUES (N'e4cf7ace-e99a-4f7b-9b13-f50f8b025f13', N'Nhật', N'Nhat@gmail.com', N'132141123', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'Bình Thuận', CAST(N'2022-11-04T06:41:05.1269136' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[tblCategory] ([ID], [Name], [CategoryID], [CreatedById], [CreateAt], [UpdateAt]) VALUES (N'930fbd18-6183-4455-8f06-3100fce759ed', N'tin tuc', N'930fbd18-6183-4455-8f06-3100fce759ed', N'930fbd18-6183-4455-8f06-3100fce759ed', CAST(N'2018-12-19T09:26:03.4780390' AS DateTime2), CAST(N'2018-12-19T09:26:03.4780390' AS DateTime2))
GO
INSERT [dbo].[tblCategory] ([ID], [Name], [CategoryID], [CreatedById], [CreateAt], [UpdateAt]) VALUES (N'605c1f09-3e5d-45f7-ab61-56973177bee0', N'Thể Thao', N'605c1f09-3e5d-45f7-ab61-56973177bee0', N'273f2176-3324-473d-8ea6-6ad987936b9c', CAST(N'2022-11-03T00:00:00.0000000' AS DateTime2), CAST(N'2022-11-03T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[tblCategory] ([ID], [Name], [CategoryID], [CreatedById], [CreateAt], [UpdateAt]) VALUES (N'f36008ae-d56a-4d26-9252-9f3ee8012320', N'Kinh Tế', N'f36008ae-d56a-4d26-9252-9f3ee8012320', N'492decad-12f2-40dd-a2d5-bee32f1845bf', CAST(N'2022-11-04T00:00:00.0000000' AS DateTime2), CAST(N'2022-11-04T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[tblArticle] ([ID], [Title], [Content], [ViewCount], [DateOfBirth], [AuthorID], [CategoryID], [CreateAt], [UpdateAt]) VALUES (N'5878cf5a-5558-4121-acdb-1a66ad2ae208', N'tieu de bai viet 10', N'noi dung cua bai viet 10', N'31231', NULL, N'492decad-12f2-40dd-a2d5-bee32f1845bf', N'f36008ae-d56a-4d26-9252-9f3ee8012320', CAST(N'2022-11-04T06:49:17.0269778' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[tblArticle] ([ID], [Title], [Content], [ViewCount], [DateOfBirth], [AuthorID], [CategoryID], [CreateAt], [UpdateAt]) VALUES (N'e622f757-e304-4679-8863-264231419d86', N'tieu de bai viet 4', N'noi dung cua bai viet 4', N'312', NULL, N'492decad-12f2-40dd-a2d5-bee32f1845bf', N'f36008ae-d56a-4d26-9252-9f3ee8012320', CAST(N'2022-11-04T06:46:32.8418116' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[tblArticle] ([ID], [Title], [Content], [ViewCount], [DateOfBirth], [AuthorID], [CategoryID], [CreateAt], [UpdateAt]) VALUES (N'b8b2f81f-7c44-4e3f-b925-2d057ff11997', N'tieu de bai viet 7', N'noi dung cua bai viet 7', N'141', NULL, N'930fbd18-6183-4455-8f06-3100fce759ed', N'f36008ae-d56a-4d26-9252-9f3ee8012320', CAST(N'2022-11-04T06:47:41.8019486' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[tblArticle] ([ID], [Title], [Content], [ViewCount], [DateOfBirth], [AuthorID], [CategoryID], [CreateAt], [UpdateAt]) VALUES (N'3d2bc3b4-d200-4c8c-b8a0-3db6a6e5d8b3', N'tieu de bai viet 3', N'noi dung cua bai viet 3', N'123', NULL, N'492decad-12f2-40dd-a2d5-bee32f1845bf', N'f36008ae-d56a-4d26-9252-9f3ee8012320', CAST(N'2022-11-04T06:46:19.5656229' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[tblArticle] ([ID], [Title], [Content], [ViewCount], [DateOfBirth], [AuthorID], [CategoryID], [CreateAt], [UpdateAt]) VALUES (N'1c1300dc-0b9e-4eee-82c6-44fa1fa6261b', N'tieu de bai viet 8', N'noi dung cua bai viet 8', N'888', NULL, N'da9b2051-f0f8-4458-bbe9-7c93afa65068', N'605c1f09-3e5d-45f7-ab61-56973177bee0', CAST(N'2022-11-04T06:48:29.0090375' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[tblArticle] ([ID], [Title], [Content], [ViewCount], [DateOfBirth], [AuthorID], [CategoryID], [CreateAt], [UpdateAt]) VALUES (N'e3ffe0b0-0660-4434-bb27-674db7492e20', N'tieu de bai viet 12', N'noi dung cua bai viet 12', N'312', NULL, N'930fbd18-6183-4455-8f06-3100fce759ed', N'f36008ae-d56a-4d26-9252-9f3ee8012320', CAST(N'2022-11-04T06:49:58.6715341' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[tblArticle] ([ID], [Title], [Content], [ViewCount], [DateOfBirth], [AuthorID], [CategoryID], [CreateAt], [UpdateAt]) VALUES (N'c8747649-1416-46a0-a5dd-6e9ce31847da', N'tieu de bai viet 9', N'noi dung bai viet 9', N'87182', NULL, N'492decad-12f2-40dd-a2d5-bee32f1845bf', N'f36008ae-d56a-4d26-9252-9f3ee8012320', CAST(N'2022-11-04T06:48:40.9983394' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[tblArticle] ([ID], [Title], [Content], [ViewCount], [DateOfBirth], [AuthorID], [CategoryID], [CreateAt], [UpdateAt]) VALUES (N'c5eb9665-b38c-4cc7-82d6-8290afa96ff9', N'tieu de bai viet 2', N'noi dung cua bai viet 2', N'100', NULL, N'492decad-12f2-40dd-a2d5-bee32f1845bf', N'930fbd18-6183-4455-8f06-3100fce759ed', CAST(N'2022-11-03T12:15:22.1903509' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[tblArticle] ([ID], [Title], [Content], [ViewCount], [DateOfBirth], [AuthorID], [CategoryID], [CreateAt], [UpdateAt]) VALUES (N'011e43f7-1d6e-4a1a-bf7c-868ff892876c', N'tiêu đề bài viết số 6', N'noi dung cua bai viet 6', N'512', NULL, N'492decad-12f2-40dd-a2d5-bee32f1845bf', N'f36008ae-d56a-4d26-9252-9f3ee8012320', CAST(N'2022-11-04T06:47:29.5375630' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[tblArticle] ([ID], [Title], [Content], [ViewCount], [DateOfBirth], [AuthorID], [CategoryID], [CreateAt], [UpdateAt]) VALUES (N'bc201c6b-cafe-4aab-85f0-d0a7ba145faf', N'tieu de bai viet 11', N'noi dung cua bai viet 11', N'12341', NULL, N'930fbd18-6183-4455-8f06-3100fce759ed', N'605c1f09-3e5d-45f7-ab61-56973177bee0', CAST(N'2022-11-04T06:49:47.7199766' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[tblArticle] ([ID], [Title], [Content], [ViewCount], [DateOfBirth], [AuthorID], [CategoryID], [CreateAt], [UpdateAt]) VALUES (N'5acd5849-7814-45f9-8479-fd072e238c06', N'tieu de bai viet 5', N'noi dung cua bai viet 5', N'12341', NULL, N'930fbd18-6183-4455-8f06-3100fce759ed', N'605c1f09-3e5d-45f7-ab61-56973177bee0', CAST(N'2022-11-04T06:47:03.7197858' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[tblComment] ([ID], [Content], [AuthorID], [ArticleID], [CreateAt], [UpdateAt]) VALUES (N'1cd76298-9740-4499-9df6-0737e0921250', N'Đây là comment của bạn Triệu vào bài viết số 10', N'492decad-12f2-40dd-a2d5-bee32f1845bf', N'5878cf5a-5558-4121-acdb-1a66ad2ae208', CAST(N'2022-11-04T06:51:01.1577201' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220930072231_Migra', N'6.0.9')
GO
