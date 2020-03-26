use gleanerReplicate
go
create table Article(
		     itemId int identity(1,1) primary key    /*Unique Identification of the item being stored*/
            ,imageFolder nvarchar(60) null   /*folder containing the Article  image*/
            ,imageName nvarchar(120) null   /*name of image for the article*/
            ,headerText nvarchar(400) null   /*Header text for article*/
            ,bodyText text      /*body of the article*/
            ,articleType nvarchar(50)   /*type of article: Latest News,Lead Stories,News,Sports,Business,Entertainment
                           Commentary,World News,Art&Leisure,Auto,In Focus,Outlook,*/
            ,submitTime datetime null     /*date and time article was submitted */
            ,submittedBy nvarchar(60) not null   /*article was submitted by who */
            ,article_option nvarchar(15)  /*primary of secondary article */
);
go