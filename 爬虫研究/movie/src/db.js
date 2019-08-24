/* const mysql = require('mssql');
const bluebird = require('bluebird');

const connection = mssql.ConnectionPool({
    host: 'localhost',
    //port: 3306,
    database: 'MyDB',
    user: 'sa',
    password: 'sa'
});
connection.connect();

module.exports = bluebird.promisify(connection.query).bind(connection); */

/* 链接sql数据库 */
var mssql = require('mssql')
var mssqldb = {}
var config = {
  user: 'sa',
  password: 'sa',
  server: '127.0.0.1',
  //port: 1433,
  driver: 'sqlserver',
  database: 'MyDB',
  options: {
    encrypt: false // 是否加密，本地为false, 部署后为true
  },
  pool: {
    min: 0,
    max: 10,
    idleTimeoutMillis: 3000
  }
}
// 数据库封装
mssqldb.sql = function(sql, callBack) {
  var connection = new mssql.ConnectionPool(config, function(err) {
    if (err) {
      console.log(err)
      return
    }
    var ps = new mssql.PreparedStatement(connection)
    ps.prepare(sql, function(err) {
      if (err) {
        console.log(err)
        return
      }
      ps.execute('', function(err, result) {
        if (err) {
          console.log(err)
          return
        }
 
        ps.unprepare(function(err) {
          if (err) {
            console.log(err)
            callback(err, null)
            return
          }
          callBack(err, result)
        })
      })
    })
  })
}
 
module.exports = mssqldb