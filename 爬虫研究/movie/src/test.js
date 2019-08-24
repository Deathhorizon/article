const query = require('./db');

query.sql("INSERT INTO movies(id,name,href,image,score) VALUES(1,1,1,1,1)",function(err,result){
    if (err) {
      console.log(err);
      return;
    }
    console.log('用户总数为 :',result);
  });

//console.log(s)
