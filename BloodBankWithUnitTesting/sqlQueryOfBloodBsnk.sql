drop table user_login
drop table user_profile_info
drop table confirmationDonation
drop table bloodDonateRecords
drop table user_notification

create table user_login(
	user_mail varchar(36) primary key,
	user_pass varchar(32),
	reg_date date,
	activity varchar(3)
)

insert into user_login values('birat@gmail.com','123456789', '2014-02-05','y')

select * from user_login

select * from user_profile_info

create table user_profile_info(
	user_PID varchar(20) primary key,
	userName varchar(32),
	userMail varchar(36),
	dob date,
	userAddress varchar(36),
	gender varchar(8),
	bloodGroup varchar(4),
	phoneNumber varchar(10),
	foreign key (userMail) references user_login(user_mail) 
)

insert user_profile_info values('UI20140206120506','Birat saha','birat@gmail.com',
		'1995-05-05','Badda','Male','a+','1275757577')




create table bloodDonateRecords(
	recordNo varchar(20) primary key,
	donor_id varchar(20),
	client_id varchar(20),
	blood_group varchar(20),
	donationDate timestamp,
	foreign key (donor_id) references user_profile_info (user_PID),
	foreign key (client_id) references user_profile_info (user_PID) 
)

create table user_notification(
	notificationId varchar(20) primary key,
	userId varchar(20),
	notificationTime timestamp,
	messange text,
	foreign key (userId) references user_profile_info (user_PID),
)