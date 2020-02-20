/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     2020/2/20 11:30:35                           */
/*==============================================================*/


drop table if exists conditionColor;

drop table if exists dateCasedistribute;

drop table if exists news;

drop table if exists provinceColor;

drop table if exists provinceCurcolor;

drop table if exists science;

drop table if exists totalCasedistribute;

drop table if exists userinfo;

/*==============================================================*/
/* Table: conditionColor                                        */
/*==============================================================*/
create table conditionColor
(
   minimum              int not null,
   maximum              int not null,
   r                    int not null,
   g                    int not null,
   b                    int not null,
   primary key (minimum, maximum)
);

/*==============================================================*/
/* Table: dateCasedistribute                                    */
/*==============================================================*/
create table dateCasedistribute
(
   province             varchar(95) not null,
   tot_province         varchar(95),
   casedate             date not null,
   confirm              int not null default 0,
   suspect              int not null default 0,
   death                int not null default 0,
   cured                int not null default 0,
   primary key (province)
);

/*==============================================================*/
/* Table: news                                                  */
/*==============================================================*/
create table news
(
   newsdate             date not null,
   url                  varchar(95) not null,
   title                varchar(95) not null,
   primary key (newsdate, url)
);

/*==============================================================*/
/* Table: provinceColor                                         */
/*==============================================================*/
create table provinceColor
(
   province             varchar(95) not null,
   pro_province         varchar(95),
   rDefault             int not null,
   gDefault             int not null,
   BDefault             int not null,
   rOffset              int not null,
   gOffset              int not null,
   bOffset              int not null,
   primary key (province)
);

/*==============================================================*/
/* Table: provinceCurcolor                                      */
/*==============================================================*/
create table provinceCurcolor
(
   province             varchar(95) not null,
   tot_province         varchar(95),
   pro_province         varchar(95),
   rCur                 int not null,
   gCur                 int not null,
   bCur                 int not null,
   primary key (province)
);

/*==============================================================*/
/* Table: science                                               */
/*==============================================================*/
create table science
(
   category             varchar(95) not null,
   title                varchar(95) not null,
   content              varchar(95) not null,
   primary key (category, title)
);

/*==============================================================*/
/* Table: totalCasedistribute                                   */
/*==============================================================*/
create table totalCasedistribute
(
   province             varchar(95) not null,
   minimum              int,
   maximum              int,
   pro_province         varchar(95),
   totalConfirm         int not null default 0,
   totalSuspect         int not null default 0,
   totalDeath           int not null default 0,
   totalCured           int not null default 0,
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

alter table dateCasedistribute add constraint FK_Relationship_6 foreign key (tot_province)
      references totalCasedistribute (province) on delete restrict on update restrict;

alter table provinceColor add constraint FK_Relationship_4 foreign key (pro_province)
      references provinceCurcolor (province) on delete restrict on update restrict;

alter table provinceCurcolor add constraint FK_Relationship_2 foreign key (tot_province)
      references totalCasedistribute (province) on delete restrict on update restrict;

alter table provinceCurcolor add constraint FK_Relationship_3 foreign key (pro_province)
      references provinceColor (province) on delete restrict on update restrict;

alter table totalCasedistribute add constraint FK_Relationship_1 foreign key (pro_province)
      references provinceCurcolor (province) on delete restrict on update restrict;

alter table totalCasedistribute add constraint FK_Relationship_5 foreign key (minimum, maximum)
      references conditionColor (minimum, maximum) on delete restrict on update restrict;

