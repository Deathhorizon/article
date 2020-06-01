import '../app';
import './index.css';
HWH5.getAuthCode().then(data => {
    console.log(data);
    }).catch(error => {
    console.log('获取异常', error);
    });
 console.log('desc');
