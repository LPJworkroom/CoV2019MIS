/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     2020/2/21 11:07:18                           */
/*==============================================================*/


drop table if exists KnowledgeData;

drop table if exists NewsData;

drop table if exists PlagueColor;

drop table if exists ProvinceDailyData;

drop table if exists ProvinceDefaultColor;

drop table if exists ProvinceNowColor;

drop table if exists ProvinceSumData;

drop table if exists userinfo;

/*==============================================================*/
/* Table: KnowledgeData                                         */
/*==============================================================*/
create table KnowledgeData
(
   knowledgetype        varchar(95) not null,
   title                varchar(95) not null,
   content              varchar(95) not null,
   primary key (knowledgetype, title)
);

/*==============================================================*/
/* Table: NewsData                                              */
/*==============================================================*/
create table NewsData
(
   newsdate             date not null,
   url                  varchar(95) not null,
   title                varchar(95) not null,
   primary key (newsdate, url)
);

/*==============================================================*/
/* Table: PlagueColor                                           */
/*==============================================================*/
create table PlagueColor
(
   numfloor             int not null,
   numceil              int not null,
   r                    int not null,
   g                    int not null,
   b                    int not null,
   primary key (numfloor, numceil)
);

/*==============================================================*/
/* Table: ProvinceDailyData                                     */
/*==============================================================*/
create table ProvinceDailyData
(
   province             varchar(95) not null,
   Pro_province         varchar(95),
   casedate             date not null,
   confirmed            int not null default 0,
   suspect              int not null default 0,
   death                int not null default 0,
   primary key (province)
);

/*==============================================================*/
/* Table: ProvinceDefaultColor                                  */
/*==============================================================*/
create table ProvinceDefaultColor
(
   province             varchar(95) not null,
   Pro_province         varchar(95),
   r                    int not null,
   g                    int not null,
   B                    int not null,
   rOffset              int not null,
   gOffset              int not null,
   bOffset              int not null,
   primary key (province)
);

/*==============================================================*/
/* Table: ProvinceNowColor                                      */
/*==============================================================*/
create table ProvinceNowColor
(
   province             varchar(95) not null,
   Pro_province         varchar(95),
   Pro_province2        varchar(95),
   r                    int not null,
   g                    int not null,
   b                    int not null,
   primary key (province)
);

/*==============================================================*/
/* Table: ProvinceSumData                                       */
/*==============================================================*/
create table ProvinceSumData
(
   province             varchar(95) not null,
   numfloor             int,
   numceil              int,
   Pro_province         varchar(95),
   confirmed            int not null default 0,
   suspect              int not null default 0,
   death                int not null default 0,
   primary key (province)
);

/*==============================================================*/
/* Table: userinfo                                              */
/*==============================================================*/
create table userinfo
(
   userid               int not null auto_increment,
   nick                 varchar(95) not null,
   password             varchar(95) not null,
   primary key (userid),
   unique key AK_Key_2 (nick)
);

alter table ProvinceDailyData add constraint FK_Relationship_6 foreign key (Pro_province)
      references ProvinceSumData (province) on delete restrict on update restrict;

alter table ProvinceDefaultColor add constraint FK_Relationship_4 foreign key (Pro_province)
      references ProvinceNowColor (province) on delete restrict on update restrict;

alter table ProvinceNowColor add constraint FK_Relationship_2 foreign key (Pro_province)
      references ProvinceSumData (province) on delete restrict on update restrict;

alter table ProvinceNowColor add constraint FK_Relationship_3 foreign key (Pro_province2)
      references ProvinceDefaultColor (province) on delete restrict on update restrict;

alter table ProvinceSumData add constraint FK_Relationship_1 foreign key (Pro_province)
      references ProvinceNowColor (province) on delete restrict on update restrict;

alter table ProvinceSumData add constraint FK_Relationship_5 foreign key (numfloor, numceil)
      references PlagueColor (numfloor, numceil) on delete restrict on update restrict;

