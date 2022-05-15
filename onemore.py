import datetime
from lxml import etree
import requests
#今日时间
today = datetime.datetime.today()
#爬取
def one():
       
       url = "http://wufazhuce.com/"
       headers = {
           'User-Agent':'Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.186 Safari/537.36'
       }
       
       response = requests.get(url=url,headers=headers) 
       response.encoding = 'utf-8'
       tree = etree.HTML(response.text)
       datas = tree.xpath('//*[@id="carousel-one"]/div/div[1]/div[2]/div[2]/a')[0].xpath('string(.)')
       return(datas)
       


import requests
import json
def yiyan():
       #一言
       api_url = 'https://v1.hitokoto.cn'
       response = requests.get(api_url)
       res = json.loads(response.text)
       text1 = res['from_who']
       if text1:
              a_word = res['hitokoto']+' ----'+res['from_who']+'《'+res['from']+'》'
       else :
              a_word = res['hitokoto']+' ----'+'《'+res['from']+'》'
       return(a_word)
       
#pause = input()



#每日诗词
import requests
import json
def shici():
       api_url = 'https://v1.jinrishici.com/all.json'
       response = requests.get(api_url)
       res = json.loads(response.text)
       poem = res['content']+' -----'+res['author']+"《"+res['origin']+"》"
       return(poem)
       
#pause = input()
#爱词霸
def ciba():
       api_url = 'http://open.iciba.com/dsapi/'
       response = requests.get(api_url)
       res = json.loads(response.text)
       ciba = res['note']+'\n   '+res['content']
       return(ciba)
       
datas = one()
a_word = yiyan()
poem = shici()
ciba = ciba()
with open(file="C:\\luoxu\\one.txt",mode="a",encoding='utf-8') as f:
       f.write(datas)
with open(file="C:\\luoxu\\poem.txt",mode="a",encoding='utf-8') as f:
       f.write(poem)
with open(file="C:\\luoxu\\一言.txt",mode="a",encoding='utf-8') as f:
       f.write(a_word)
with open(file="C:\\luoxu\\ciba.txt",mode="a",encoding='utf-8') as f:
       f.write(ciba)
with open(file="C:\\luoxu\\集合.txt",mode="a",encoding='utf-8') as f:
       f.write(str(today)+"\none一个：  "+datas+"\n一言：  "+a_word+"\n每日诗词：  "+poem+"\n爱词霸：  "+ciba)
with open(file="C:\\luoxu\\集合read.txt",mode="w",encoding='utf-8') as f:
       f.write("one一个：  "+datas+"\n一言：  "+a_word+"\n每日诗词：  "+poem+"\n爱词霸：  "+ciba)





