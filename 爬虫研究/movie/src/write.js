// 从db.js那里导入query方法
const query = require('./db');
const test = require('./test')
//const debug = require('debug')('movie:write');
var util = require('util');
const write = async (movies) => {
    //debug('开始写入电影');

    for (let movie of movies) {
        // 通过query方法去查询一下是不是已经在数据库里存过了
        let oldMovie = query.sql(util.format("SELECT * FROM movies WHERE id=%s LIMIT 1", movie.id),function(err,result){
            if (err) {
              console.log(err);
              return;
            }
            console.log(result);
        });

        if (Array.isArray(oldMovie) && oldMovie.length) {
            // 更新movies表里的数据
            let old = oldMovie[0];
             query.sql( util.format("UPDATE movies SET name='%s',href='%s',image='%s',score='%s' WHERE id='%s'", movie.name, movie.href, movie.image, movie.score, old.id),function(err,result){
                if (err) {
                  console.log(err);
                  return;
                }
                console.log(result);
              });
        } else {
             query.sql(util.format("INSERT INTO movies(id,name,href,image,score) VALUES('%s','%s','%s','%s','%s')", movie.id, movie.name, movie.href, movie.image, movie.score),function(err,result){
                if (err) {
                  console.log(err);
                  return;
                }
                console.log(result);
              });
        }

        //debug(`正在写入电影：${movie.name}`);
    }
};

module.exports = write;