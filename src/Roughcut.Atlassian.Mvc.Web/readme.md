## Working with MS-Edge, IISExpress and Visual Studio

[Follow this link to resolve iisexpress / localhost 'self-cert' error](https://stackoverflow.com/questions/62699391/how-to-bypass-certificate)

## Integrated with MDBootstrap and FontAwesome
Using the ‘free’ version of md-bootstrap-5 (MDB5) and font-awesome (FA) for the UI components.
- [MDBootstrap](https://mdbootstrap.com/docs/standard/getting-started/installation/)
- [FontAwesome](https://fontawesome.com/v5.15/icons?d=gallery&p=2&m=free)

Following downloading instruction and copy src-files into wwwroot for reference
- MDB5: `..\mdb5\7.2.0` -- example:
	- ..\wwwroot\mdb5\7.2.0

Update the `_Layout.cshtml` file to reference the local files:
```html
<!-- MDBootstrap -->
<link href="~/mdb5/7.2.0/css/mdb.min.css" rel="stylesheet" />
<script src="~/mdb5/7.2.0/js/mdb.min.js"></script>
```