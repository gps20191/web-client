from django.shortcuts import render
import requests
import json


def home(request):
    url = "https://alerta-api.azurewebsites.net/api/alertas/"
    r = requests.get(url).json()
    for i in range(len(r)):
        dataHora = r[i]['dataHoraRegistro'].split("T")
        data = dataHora[0]
        hora = dataHora[1]
        r[i]['time'] = data + " " + hora
        r[i]['localizacao'] = str(r[i]['latitude']) + ' , '+ str(r[i]['longitude'])

    return render(request, 'lookatme/alertpage.html', {'alertas': r})


'''
    dataRegistro:str
    horaRegistro: str
    estado:str
    numeroOnibus:int
    latitude:str
    longitude:str
    suspeitoID:int
    urlFoto:str
    
    
    
def busca(request,estado:str):
    lstEstado: list = []
    requestJson = request.json()
    for i in range(len(requestJson)):
        if requestJson[i]['estado'].lower() == estado.lower():
            lstEstado.append(requestJson[i])
        #
    #
    if (estado.lower() == "Em Andamento".lower()):
        estado = "Andamento"
    return render(request, 'templates/'+estado+'.html', {'alertas' : lstEstado})


# Para testes do módulo
if __name__ == '__main__' :
    url = "https://alerta-api.azurewebsites.net/api/alertas/"
    r = requests.get(url).json()
    for i in range(len(r)):
        dataHora = r[i]['dataHoraRegistro'].split("T")
        print(dataHora)
        data = dataHora[0]
        hora = dataHora[1]
        r[i]['data'] = data
        r[i]['hora'] = hora
'''