#  使用基础模板开发
-----------------------------

### 目录结构

- [新建项目](#新建项目)
- [工程目录](#工程目录)
- [页面配置](#页面配置)
- [引用图片](#引用图片)
- [如何引用第三方框架](#如何引用第三方框架)

### 新建项目

通过IDE**新建项目**，选择项目类型“**基础模板**”下载项目。

### 工程目录

```text
  |—— build // 打包生成的app目录
  |—— public // 公用文件。不经过webpack处理，需要在html引用
  ├── src // 源代码目录
  │   ├── desc // desc文件
  │   ├── html // html文件
  │   ├── app.js // 公用js
  │   ├── app.css // 公用样式
  │   └── app.json // 路由配置文件
  ├── .eslintrc // eslint配置文件
  ├── plugin.json // 项目配置文件
  └── wecode.json // 本地开发配置文件
```

### 页面配置

在项目 src 目录 app.json 中，添加配置，如：

```json
{
    "pages": [
        "html/index",
        "desc/index"
    ]
}
```

以新增 `html/index.html` 页面为例：

<li>新增两个文件 `html/index.html` 和 `html/index.js`。
<li>添加配置，将 `html/index` 到 `app.json` 的 `pages` 字段中。

注意， `index`.html 和 `index`.js 两文件需和配置的 `index` 命名需保持一致。

### 引用图片

图片资源可放在 `public`中。

举例：

一个图片存放的地址为 `public/images/logo.png`。打包时，`webpack` 会将 `images/logo.png` 复制至打包完的目录中。

> 注意，`public` 文件夹本身不会复制，只是里面的文件，所以引用时不需要带上`public` 文件夹这一层。

在 `html/index.html` 中引用：

```html
<img src="../images/logo.png" />
```

在 `html/index.css`中引用：

```css
.logo {
  background: url('../images/logo.png')
}
```


### 如何引用第三方框架

如何引用第三方框架，如 zepto，vue 等...

**示例：**

global引入：将压缩过的 `zepto.min.js` 放在 `public/js` 文件夹中。

在 html/index.html 中引用：

```html
<script src="../js/zepto.min.js"></script>
```

在 js 中引用，如 `html/index.js`：

```js
Zepto(() => {
  console.log('Ready to Zepto!');
});
```

**注意：在启动过程才会复制 public 里面的文件到项目根目录中，所以需要重启才能生效。**