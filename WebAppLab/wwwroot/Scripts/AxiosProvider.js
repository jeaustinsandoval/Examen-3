"use strict";
var App;
(function (App) {
    var AxiosProvider;
    (function (AxiosProvider) {
        //export const GuardarEmpleado = () => axios.get<Entity.DBEntity>("aplicacion").then(({data})=>data );
        // export const AgenciaEliminar = (id) => axios.delete<DBEntity>("Agencia/Grid?handler=Eliminar&id=" + id).then(({ data }) => data);
        // export const AgenciaGuardar = (entity) => axios.post<DBEntity>("Agencia/Edit", entity).then(({ data }) => data);          api/Agencia
        AxiosProvider.AgenciaEliminar = function (id) { return ServiceApi.delete("api/Agencia/" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.AgenciaGuardar = function (entity) { return ServiceApi.post("api/Agencia", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.AgenciaChanceProvincia = function (entity) { return axios.post("Agencia/Edit?handler=ChangeProvincia", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.AgenciaChanceCanton = function (entity) { return axios.post("Agencia/Edit?handler=ChangeCanton", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ClientesEliminar = function (id) { return ServiceApi.delete("api/Clientes/" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ClientesGuardar = function (entity) { return ServiceApi.post("api/Clientes", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ClientesActualizar = function (entity) { return ServiceApi.put("api/Clientes", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.UsuarioRegistrar = function (entity) { return axios.post("Registrarse", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.Login = function (entity) { return axios.post("Login", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.AlquilerEliminar = function (id) { return ServiceApi.delete("api/Alquiler/" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.AlquilerGuardar = function (entity) { return ServiceApi.put("api/Alquiler", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.AlquilerActualizar = function (entity) { return ServiceApi.put("api/Alquiler", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
    })(AxiosProvider = App.AxiosProvider || (App.AxiosProvider = {}));
})(App || (App = {}));
//# sourceMappingURL=AxiosProvider.js.map