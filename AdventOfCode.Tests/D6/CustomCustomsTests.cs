﻿namespace AdventOfCode.Tests.D6
{
    using AdventOfCode.D6;
    using FluentAssertions;
    using NUnit.Framework;

    public class CustomCustomsTests
    {
        private const string _puzzle = @"tzibqaulrw
bratip
trbhia
rtiab

sgqytjiw
gkwqybtims

tufcqanysox
ovufxnaqt
aenbqfkutgjx
taufvnxqi
nuaqxfmsth

qj
jsqx

gltviuzdrkema
idclmuektgora
idayrlmgukte
xailwumktdergf
jmrniauldbthkpqge

zc
ucfhz
cisz

i
i
i
i

rqigekxlmzswycnjhfv
lznacirjfkyvxwsmeg

bohsmgujxdnrwza
pfaeqkinwgxjt

buhiwcayjsdlox
hxoiajbdyucswl
asildxjbcywuofh
iyduashjcboxwl

rhkfis
srfhki
ykgfstqprhic
kfhsir

gbzcuqiow
cwoqbgzi
lpqzwosibcg
zgowbucqi

fdveytbpijnohu
grlwctfqzksuxim

b
bmd
ln
v
b

lmozeafivktr
rtpvofl

gmxertwia
xitmfqwarzh
rwximagpt
tmwaripx

hzldcoqpafkt
aqwgsrxmv
niauqe
jyeqa

aep
dop
lupd

efhlq
flaq
qflwt
fqmpl
ltqf

dnoumwkb
xabuw

ua
hzlu
uj
ou

he
h
he
spfkhzoyvc

yznp
np

nre
n

tqxjlrpawhbgvkumyszi
ylavhburmstjgqikpzwx

sraeuktbvh
muhtbesavrk
euatrvhkbs
hvtksbaeru

zmqvkue
kmhvu
umvk

qzgrivbwtonhdc
grwcibmtvzhdofnk
btgsdhpwcuavnoi

srigyn
ycjn
ny
noy

rtbyuhocklijsqfnavezgdwx
tpibcjzerlaswumdghoqfy

lukynotgeqbdi
bgoylqkniued
kdeiolnbqugy
ydelinbquogk
nekilobugyqd

ywe
suaqdhtz

vzobmej
sizedvpbj

derbngzw
nwgrbdze
zbwhmergdcn
dwzgnber
sberdnwzg

oz
zo
oz
zo

dtkq
kdqt
tqdk

vogmbel
emovlgn
logmev
aleovmtg
ovesklygizjmurqc

cr
rt
tgi
nahex
vuz

dsfxounj

o
oehk
ym

fkbje
muhobseck
pbxkeg
eqbxkfd

wkheztoycbi
jofzubhtewnk

uocbzkrtvlmn
lcotbknvurz
ztclrvbnuok
cokbzlruvnt
kbzcoearnvtul

fyxt
txf
ftx

zxklciqthyfuw
yqtxlkwhzcufs
lthrfqyuwkzcx
yxlhztfcqubkw
wctqklxzyfuhm

dgesru
cxruyjd
rkqldue

yckqsu
exri
hfwmjpnvdg
yiu

nlomrcuexf
zqxurmvlnesf
lermufxn
lunemfcxr

ridaxtcjkmylwe
jeriymacwkxtodl
jldikatemrcyxw
kcaidtxwyjvemlr
ylwkarcidtmxej

caekhtg
ocktg
dogckt

p
a
p
sbqi

xkycajft
sogfnyd
abyhftpjxk
tkxyflhe

wcqrv
qacj
qbfd
zpq
qm

tdabm
fsamlb
thbamd

jodrxcp
ruadmv
krfngdqezihyb
stljmrcdpw

fbstci
wjqe

ahtfkpxqn
pnlkstvoajzudm
zpiatnkw
awnsktp
matjpnk

ameoh
hmenoacq
hoema
eamoh

rtmiqj
irnt
geyhsdftzika

smditfuacpnzwle
auslfncmegzihbp

xymrjlip
rjmtiwpkxly
rilymjpx
jpixymrfl
irmjyxlp

whavgdmlzbekf
hfvdmbliwgkpe

rjawtqd
qatjrdw
adjuwxrltq
wdaqjtr

pfeuiqsdahb
equabhip
heiupabq
aieqxuphb

cymzbepguskinrwqhd
wyqkmscigehrvdbpunz
wusdinmkhqycgezprb
icugyzrnpwdksbhemq
ubzeskcnqwhdyrmipg

eignhalkj
tbnojhsfkru
ndvjeykh
jncmkwih

notudfbqhrajywsg
jsrhyufndowatbqg
hsgwonrbyjqufdat
ujhtaqsndbowyfgr

vwcfndmjze
cqzvwfmdnkgpijerty
mvjnzfwdce
zcnwvmfjde

ayt
tay

vgabymcl
ydmqvph
yvouqmw

vb
vk
vb

szhk
va
zhcdkw

aelhozrnbyfcsugwkiq
wthqenkfysagloirczu
kiwzcrynghfsuloetavq

umlgjeoz
yglmfxcrpz
miclgzphk

vkzljpfn
kgcyhptqu

dietxnj
tvx
wtx
xotfbysump
xitk

wiselg
sgjewzi
gwesti

saq
sqa
psaq
aqs

bvjixwhtgofny
cqlnhgjetdubp
qrgnhmajubt

pqzej
qjvpy
wjpvq

hxauivlnjtzg
nhgaiuxljzt
uigtlnjaxhz
zunitjxlgha
hxjztainglu

nhjwyoegafutipzx
yzclvwnqsbmf

gdej
ejdg
gjed
edgj

j
p
l

x
x
xgn
x
x

krp
pkr
pqkr
rpk
krp

arch
ahrc
rahc
rahc
crahk

qayg
gyaq
aygq
qayg
gqya

pwjiteyurlamnkvfqh
kwqhvazimufjxysr
vafqmkhyjdwuri

kryonhgpx
ptycxirgsnuhw
hgryxpvdn
gyrxpnh
xjrpzdyghfn

bw
w
w

knhfqxlpajyes
ashnxpjkel
pxkjnlaehs
sjkexhpnla
euhpnxkljas

wyugbiotdlkpa
duiyopablgwmt
tzaidwhlbpugyo
gtsyabdlmupwio
owabgiytpldu

oitpjudvmnhr
itvzhrunxjmd
jcdthivunmr
tmhcujdnirv
vtkhnfjrmuid

yxl
yxl
lpymx
ylx

ejdx
ejdi
jexd
dnjet

ycjfosn
uakdc

rl
lr
rl
rl

hakebywjfz
ftrnazjyuog

rx
xh
rlx
x
x

ugwmbfvqnhstjpcxkdrayz
bgtrmpxnhykajdvfsczuwq
czrmqwfkpavyjntbudshgx
mzardcyqnhwstxpfivbkjgu
ufsnjkvczhygbxmqtwdrap

n
tn
n
n
n

uz
zu
zu

kg
gk
kg
gk
gk

rhjtbwuom
mtohjrbuw
ruhbtmowj
jhmuobwtr

gznfydhcerapjk
aghyfkrepzcdjn
fzykhceapdjgrn
repcjazdfghnky

rkszmwlyg
slmyhkg

fyg
zlduqf

xdhkrtzfblgucm
dzcbkxguftm
xmglubkodtcfz
gzumkvwfbxtcd
kyxbuzndtgficm

wbd
ybzwd
dbw
qdwb
audbwjf

ambzfqhwuxilkjtvdysgnc
wztfjngqdmixrkhvcabyls

rn
n
n
n

x
e
y

pjtuoy
jupty

bi
bi
ib
bio

jkwao
kanwp
jxkwadn
sykwiatqfhu
akweb

gbnqicrtvfwxemsulyhzpjdo
fwseczqvuaxydkbtlmpgojhrni

hbsxc
bsxhc
bcxutsh

ai
ai
ai
ia
aiz

mdsotrjbz
mjhodtr
kdbqmtraoj
itxdjrfloewmp

xiaujwtsepyqghorkmvzn
zqrepovakmhwsgctyujnxi
jrqsgeuinpahokwvybmfztx

pekicrunhwfagztxlbqvjodys
hypaiqznotwvfrukjbgesxlcd
azgexowjkvupibfclqshnyrtd
zjrptvhkoscyxgnliufebwqda
iafjydlzscvgorwekbunhtqpx

d
b
d
d

us
u
ue
udf

zxb
bxq
bx
auxb
jxby

uc
cu
cu
qduc

wsgxjpileo
jecwhxgli
loxjbidwg
sgjrfloivxw
lyutjxgwqmnia

rgpnjsk
hsarcpkyg

jwday
wyabdj
yawjd

kgebispdzawc
jtusqpnxevdo

nclydhgxfskjra
zqyrexophsntvk

dickbg
kzgcl
ctgszkf
kyxwgc
qklcg

iuxjewc
hnitdsa

shwecrzfybn
fbnczhwjsre
csnwzkfevbtrh
rbfxscwzhen
wbrspfezcnh

snzohbrd
rsnodbh
ohsrbnd

bcsxkvdina
dcnasbxikvh
vnixkdbacs
kxcvsitoabdn

osmejrxpdqafiuyt
ybtdxfcqi
izvtbfdxyq
dlyzqwtxif

a
klu
xdo
ym
a

nplqkdgbhcmyvo
pvlobnkdhqcmyg

aqjsltmevgkyicfxbpd
xfjskpcghdzqbyvtali
baqgcyikjfdtslxvp
gmcpafyvqsblntijxdk

xrozsblqiuctkpmadevfjygnwh
koieqxhrfcludpajtvsmnwygbz

uxlnfwezmvhqac
xfvmahznluqecw
qhanxzlmvcefwu
vumwxsnaepczhlqf

uriqgsndka
nucqgskraid
rkgaiqsund
qgansrudki

ywgkostl
gthinksl

giencrav
nzwaicjreb
erfacin
aerikcnf

ilruqmyepxtzvdhwaokj
tjazhirdulxyowqvmepk
tykmdqljreipvoazwuhx

nbfzxtpuogecwm
fptcxomenyzw
micponztexfqw
wfpzxmtoercna
mnpwtcoefxz

xyehpcmkwujas
jxalcreyguv

bpcksrnwvxejaiyduzfqm
xsurzqdfnykvpwajeicbm

hfanwsmvxgprqktu
ehpxfunartvlmskw
avwnpkhxsmufrt

condegyuwzvirxfmt
oamdtlrkpznwuyighcs

efg
gq
jcrgoy

rbimtsdvcunaeo
cumowdrasvbjni
rsbciunvodwqeam
vtanoimdrsbuc
mosiahdnzcurvb

gc
cd

yxhjicel
ntejqyxlbich

ofbpy
eylkdvctnigwq
zyp
rbmy

qlg
glqj

k
u

ibzehtravqoljudgck
bqcgjuldhzoikvrtesa
tukleadvjqgobchzri

ogyzepqhkxd
qoeyxvwdghkz
qpekoxghzdy
gzdxyhqkopre
egpoxdzhykq

hyse
a

aymolrwvgxnzcuje
wlegcjzqtydipkfbnhus

tryiswmcdhxnjolzagufvp
mwfsoznjycaxhgrdutip

bglatxso
cxs
pxsrz
mxs
sxi

iu
iu
iu

xdj
dxj
jdx

atsnmu
uctkmbd
ohwvyux

rng
nrg

anml
amnlf
mlan

i
i

ag
fvugtozl

bexdrvtjfhlu
flvedkphugb
guhevfl
hoezlfwuqainmvy

fp
fr

ijruome
dqjmou
orjbmu
eoqtjmu
mfouszcjnkpvxh

uxvhtednwo
ibzpqyfkjs
lmcearg

ujnzphr
upzjhnsrc
phjrunkz

qsnjalim
dqivpj
eqivdgjo

dpcsv
psdcgefvj
pxasdvy

upnjbfosmdwrx
dquexrwjbgsmkfponc
sdjpmboiuwzfrtxn
sypuflxrdowvnbmj

vebdguwjztyasimlphroknxfc
utyflrganbpwivsxeckojmzd
xosrdauvkplewtbjyqicmgfnz
sbmivuezwxnogtdjacfkylpr

huswqyvi
purvzc
gnjalmxkebt

ypkmxsa
qsiabxh

bduhspmrekj
spuhkdbmjre

wvfdnylxarcgmsohutz
oyxtualnmhwzfgcsvr

gvyfsndlmrbuj
cvjrzlgbiydxum
kvupgelwrohytqa

fxeoukmpstwbavjqidzrgn
kuldjegzmoabsfitqvwrxp
mfsxpdioawterqgjzkubv
upxkzisvabfwqdrjogemt
idavsoutpebxjrlqkwfzmg

oylj
jbfxidqloy
tjyoacl
tjyolc
gyolj

hjebtiknfgwolucrv
frwivkncsltyogujbe
guonhbfekwcjltriv
qfcwndvzelbxjktaogrui

sekdmtbofqvcxgyujwi
juisgymxobcfktwqldve
bwxygvdtkmjiuocfseq
kotvyqixjfbeugcmwsd

sejkcndwlr
tamnfqiuypg

piuxnqtmrvdgzoahsecwylkfjb
lckoqhazfgmvpsyjiuewtdrnx

oseynjvl
igyxfb
qywkxp

cgbnifrsqkva
ivbnkwcsgqrf

zvcjysphw
vspzjwcyh
hzwjvcpys
zsphjvycw

ziugf
gfulo

nkcdoyh
dqychf

mzaqgbe
gxdyljt
mnigs

dirs
sird
dirs
dirs

yaetmuvxbgpz
igxfbzau
aonshlbuzgfx
akblzxosug
dgxuazqobw

ij
ji
jig
ji
ij

boyawrci
ydqjbnaicze
cwybiaul
saiclby
ibsfaylco

zokcdlxer
srdxzcemklo
lrzdkopcxb
rwdgcfkzlqxo
zolydkhrpixc

rwahi
hariw
rawhi
irhaw
awhri

xfogrm
gtfoxr
oxflgr
zdjoxfrg
gwvpfarxshqioy

c
m
hmc
q
zk

nxpukbselvacd
avwkfltxune
evxnolyauk
enarvxjlzku
lakqjmevunx

vsjonahc
zskvynchaor
vobjhnxasc
scoaxvhn
osacvhnx

apu
pzau
guap

vdcjkzyop
sanxruilvzqftjed

yqdvmspliwor
zugkbxaftc

anmldsq
qmadsengl
qlmxdsna

nwrlixv
xvinrwl

vftqailjwbreokxhcgz
vljrahznwcumdstoifykqpb

lue
aumlsq

zcafriuk
izrca
ztordcia
zcario
wrizandc

xat
xt
tbmxr
txa

ljbgiwczuf
eyfgncqwxhms

uvzaf
azjmqfvu
avzfu
azuvfc

xobrfcah
arzitlcmuofbhdvxe
hasfcxrbo
cxoabfrh
aphfbcsornqx

n
n
n
grnc

duhombwanpxkeqgyr
ncbzdivo

usbpqzjnkcg
gnzbujqpskc
wsqoguzcjpbk
zskuqbpgcj

ayfvxnbitepuhwmzk
pvxaezblnikwtym

awxjiduosnlbgp
lsdjexngowb
lmnoqsdfgxbw
golwspdnbxhc
dlngtkvwrbxsyoz

utc
tu
ut
utqk
ut

pjesdlyxahq
qrhjdaeplsyx
xaoyephqsjldg
yalsxdhjpeq
xpdjuysnhielaq

hsixwqutarzgnlfypob
tsoxygaqpirbnhwfluz
urahmlxqbwtiynsogfpz
bqdhrwcogsatzfvnxluyip
zilogsxhqfyauternbpw

uzsbxmp
bzumsxp
bzxmspu
bspuxzm

trhowybefszxlvmj
lbtjxzevrmfwyos
nuzdlwjeofbvxqystpmra
blsmvyrxjozwfte

s
f

egtcbmpiwlauzdxfoskj
oufmwkgaxilcjpteydzs
aijgdmzkeutolxpsfwc

zynbsokqglw
qzbglkonyw
lgnwqkoyzb

zc
zsaihrvmd
fnbzyx
cnz
z

niemkuvcqlodasgwfpbryhzx
yfztdwqrbipuoekshclamnxgv
imxvqubnzwdprhfeslycakgo
fkizrpbowlcausvqeymdxhgn

ekzmogj
ifbovnmscwqjrz
zumjlado
omkzhajx

detznuqox
qkmxeznfuao
ioqclehzungv
qzukameton
neqzou

ao
gjx

bvujqfwz
bjwmvoqzu
ubzjwvq
jwvuqbz
uvbwjqz

zmwkup
pkumcz
ujkpmz
kmunopezy

bpdgqu
xwdu
lduct
bdukg

uypwohbtfgxzcelinka
lputnozwickxafbhey
nfsldvtkawjozryxuhbpiecq
gepihncbwzymtaxfukol
utlkagbhexmiywcfzonp

swaxmgqdotzcf
gdzmaoxcfqst
qsfzxtacndgom
mszapvchdfgxqto
afxqdtiogsmzc

inkowyaxd
iksfa

dwyvekqcjnltfsuga
adsvyuqxcjelmwgrhnfi
lcjenwsfyvuzdqgap
ykwfslnuedcvaqjg

v
n

e
e

ikg
kgi
gki
kgi

cusnrpimotdvbe
hglozyfxka

iqdmwlgotup
peotmughw
wvpugfsmbl
azupnrcgmw

qaexpkir
ahpeslcgryqx
npexiqramv
xuwtqaoepr
dwpvqxaezor

febixrwpqzt
qiwbpftzxr
rojdiptzhqlxb

nmqykjecutzb
btqyuemnkzcj

dfaqjmlhrn
nfhjxldb

gcfhbvtjroud
othdrejb
rjdothby
ytbrjdoh

fyhbzwce
zwhycgeuvb

scdyijpxlkth
cxvlokb

rcseafoikwqnzmuyxgp
amzcnkjfwpsoxhrgqeui
aczsmqfgkeuniwpxro
vekucomxwziprsnafqg
fuzxsntqpmekgaroiwc

gzqxvsyjlorkanbm
mbihoujlzvkyftqxc

wvigycal
wxovlaiyc
iayvbcemhw

hzfktviwaucxqdp
xouitdqpce
cjuyiqopdtxr

ahgewbycqkrtuofz
qgkpflbwreuzcatyho
ghaytkwjvrxfbzeocmun
ktczaorwuhpelfybgsi

rcsbidmftonajzguxkl
gfrjxasiowdkzmltbchue

zv
v
kv

agzckftjlwrbnqs
nbmqihwarls
aldrhvnbspweq
anqrislmwdxbe

d
d
d
d
d

ckdw
cwdk
kwdc

crbz
bczrk
bzrc
zcrbdo
brcz

waximys
fayixsw
ayswxi
aywqixs
bsijwyeax

wkbphmtnqsreovgzilcfd
ybnkftpmqcehwsvzdig
tgqmkihecpldbzwsvnf

jxduyczbqtroslgf
ucosgyflbrxtjdzq

xdwyculk
socfwapbyndq
cdrywk
ydkecw
ydwec

slcfgrptbawyz
xcgsajldf

bt
bd
bd
obvf

xnrgsojdtbweklzmf
kemxhlnzgtasowjr
metwnolxjkagzsr
zgkwlxtnsjorem

geb
bge
ebg
beg
bge

zqfoi
czor
ozr

xtwci
hwic
fcwmbsvik
wbhcvi

ij
j

ztpe
bhtvze
tzve

mvarxklhpuwgfqisno
iwqoxmrspavulfgkn
qxnliofrawvgpskmu
zpocgqwslmfinkuarvx
kfnwugoqamvirxspl

gliotzc
toiclz
tzocil
otlzic

jwomnhaeqypsrcdvb
rutegcfksqjobzhwvaxy

onyz
ynz
zn
anzvb

htn
j
j
q
z

g
p
ejob
gp
p

leuhov
gluov
owylvkgu
vqilxacutso
ulzvjo

fmvirwpxyjsbktcgu
rxtpcvfjmswbig
glifrcjsmvwxnbt
fsmvwbtgcyrjix

rdhsi
dsihrkl
bxmwvfigjscpou

i
i
li
il
iev

x
hx
xlu
x

znrihtgoyclewxufvmjqdsap
uydbshfjpricgqlxzotvnawme
njaewixzqsfvyhudmopclgrt

ywmjslkaq
ymjswlkqa
kqaslymjw
kbjwamlfxiqycs

u
u
gu
u
u

ilqeypzcdkghvwf
vjzuatxmynl

eurqj
ftdqnrhwpexm
bgrzykloiav

vaesdnwtkzpjgobr
franjmdpbwvkhstz

knfd
qscf
gwezhtraub

arbfhjwnozskup
pblxhusowanikcjfzer
baojpshrfukzwn
ntrabwpuzkhofsj

wlkxv
wylvk
vklw
vmwlk

aevjbxrcn
ncbrjvxfa
cbxarjvn
lanbcjxrpv
bcrazvxjn

tps
ptwj
tp

p
p
p
p
p

hdieog
nzytxbgwdmih

lximqcbst
nbfelsv
vldsyb

yn
kleqmy
xsftyvzg

r
r
r
kvri
r

viadbglmf
xpuligmdvrez

hj
h

slrychvqfutbwgij
yjwirsdbthfgvlucq
ylrfubqcwzpstivhagj
fbslhcgydvqutjrwi
bfltcjsvruwyhqig

o
fo

csnkryxqzive
avcesuxzinrk
csrxnieyzvk

bjhritmcyaqzx
pajrbhqmcityzx
hrjxqibtcyamz
tmhqrcxjzibya
jrzimbxthqcya

zpnicmvkuey
vyckmpzueni
vuzcnimykep
zpmencuiyvk

ofclhwkpmvzrb
vlmwhxpzobrfck
vrmzwlhbofkcp
zcmkhybpjalofvwrd
hbcvzlrpfkwom

i
i
wi
fghsbi
i

oekxhj
ojhke
eojkh
oekjh
hekjo

ovznb
bozv
vbzo
vbzo
zbov

x
x
x
xg
x

stredcvgnfo
posxbtcrvdf
ovtkzhsfdcr
oasrfcvtd
vxsdkfortc

e
ei
vl

yrzfnigmel
rzxpfewymkg
fymrzqeg
rmegfyz
rfyglzme

dn
dn
jnh
n
n

cbxlgdijtepqzhoasf
lfgrhspbocjtaqz
fajzghlcobpstq

whbflnvragce
ybxrhucaqlgoe
tlagchbwers
fbahlzcedgr
phgeabcrl

cjimd
ji
unefjiz
pdcijm

aqgifr
jupnyokb
vez

qzfeomdngv
rnoeadygvz
prkgovedzq
mdenvgrozwa
gvxosdizbchle

saimprhqfdzeb
ijlbfqsmapthrz
azpsmciqfhbr
fbvcmzprdqihsag
hpmsfcaiqzbr

gtluiodvqcfwpezxar
fgtzoapqrwixevlduc
ztgxrlvdwcoqfupaei
ceovtdwriguplzqaxf

imhbnkouvq
nzbhumvaoiqxyk
khbmwivzqnou
fqksobmdntplcrghjv

ermxbs
wbahm
nbmsyc

bcaxqlrkpiju
bykipwmxhosvjtadfg

jark
naovkc
kta
qjatk

jtur
ogvxtswlrbyd
kamcqiehzftn

vowkmxnbtarz
mtankxrzqc
kzalpjxrtyisndfm

wlrmfi
mwirl
mflirw
rmsilwq
mawflir

clptnwrbqfmoxdekvh
fqtomhnlxbdpckurzv

kqvzoinucxrfmtgdab
ftrxqujybamviock

saquhbyzltckipv
rfydwhta

nuwp
waxp

lsyvaufoqhrpzbc
hnibpcvzjeraft
acrpezfxvbh
bcrafvzhp
rbcgzhepfmav

t
t
t
t
t

katgbyospjmvq
gtbpvayfjm
pdcgwmrlxjtiuvazb
tmbjqgavep

sdilhvype
dlheyipvs
iylsvdepqh
hvspdiley

jothzcvmearxglwknb
oacgkwemiltszbhyj

ftpgjlkydqnvx
wcmbgayhepsu

rj
rj
jr
rj

wruqfn
wrnf
wfrn
wrnfd
nfwr

qesvafzihpnuwom
fgqzdvnuyrpkto

oiverlqwc
ewlvqcri

pu
ul
kcn

gvsobqtz
orxgbszqv

bijmqg
xoent
fqmbhckjy

ygthqofjcezdxvpumwsar
ubomzvxernpyqtwisjgdcf

rzkp
krzp
rzpk

axzqd
xzdqa
dxaqz
xzqda
sadxzq

wgmhlokxtaevdisnqzpfu
msazpgtiqovudhkwenflx
fwuxprbhqzsikgltoamvn
zpxomiaktvgfluqsnhw

w
w
w

djq
syzujvq

lpjgfztr
fprtselk
rtbnxpi

xrjv
gwvr
vnorzc
trvkxnm
eqfrdvhu

duvs
usvd
svdu

zjusxkvfan
zpugndafxkc
unvxrzakf
xjeaqzkfnu
aokmwbunxz

keznrlh
reqklzhn
nrkzlhe
lrzhken
zenlkhr

fkdicgvtxwyljzmrbane
brmiwkyagnzvdjcflxte
tfngdkxvbazmerlycwij

j
i
i

eskxrlhypidgn
tgxupabzohcqdfjvi

vzkjoftgal
ig
egm
eg
g

uqgnpxzfk
esxknaqumy
uqxkmn
unxqk
kunxbq

ceiq
kvsa
ey
i
ye

aug
a
ziax
la

emof
dlyfmcpegov
ewofm
omexf
srxomef

cpmunao
wixbghflyrsjk

nomxkbvwdugfy
eudqlbnavmwgfc
wngmpfujdvb
wsuydvigmfbn

kvmsowiyhzpjtxqde
zspreijdqvmkhofy

pv
k
zweoxj
v
c

cxlfdbrw
fwdxbrlc
fldcxwbr

zeucawiobs
pyuoxtvslhrqfj

jexfokgr
gfrmxoejk
oefgjrkx
ekgjxfor

zcyprimjvxl
krftbqjehg

jkuzlfanpo
lnfiztxku
unzfbklsg

zydvesibomqnxpuj
psvmeiobguxjqytzdn

ov
vo
vo
fov
ov

vszbrqjciunl
jzlsviubrqn
lnqsgzrbviuj
jbsrzlinuvq
rijlnbvszqug

slfaixrthqm
dwhxisl

bpcmeigzfxshrknaqovyluw
uwkmsincqgohabzerfplvy

datp
upad
apdrl
atpd

rxqagfcovbyemjszwpt
crwpzuvqxsobafejmgyt
brjsofpqamvzewytxcg
vfazwpbosjqcmxgyrte

xarhtzofq
pleaghnzf
auzfnh
aihkgnecvlzf
fahz

bqpfklhurgyv
xtarwenjcds

r
ir
rqk
ri
mra

sucdinjo
jh

nofswldrtphm
ftxrmsjwhdonl

tsjndmcegqxfa
rybznihlwug

d
a
a

pzx
zupix

hcbwx
cbxwh

z
b
b
d
pwje

chsiyvgluf
pkqex

qtaygsijlemhnzfwvdpb
nbzqcmdawpgiytslef
bwptzeaolgfyndxsmqi
twfnazdloqrmpisuegyb

zrtkd
kd
adk

lsthiu
celjykt
bzodwmvfq

xyed
degx
leydx
yexld

pwvksitjo
dkvswjtop
psjkotwv
tswvokjp
pkotwjsv

xhrklytosc
sylocx
colysex
elsyocx
icolyvpxs

loastvxrkdpchiy
dohystixakprclv
hsxpcrvldyikato
dthlkoxasrvciyp

fvcyglipjebhutsaxrn
trulaxbcnsjmpwgfeyvhiz
ajyhvxtglodecbpufnksri
aufhpjercyxlnbisgvt
lvjasgifxnpyhbutcre

scvkwyutdeng
jyahqz
bfyhl

vuiajyrdqgfxepczth
apczqvjetdrxfghuyi
crfgytlvdpxauejhiznq

apyfgmtnibrkocduxvj
myodxpcarvtniubfgjk
putnocdmkfjbvixryga
kgbmnatyfixopcurjdv

evxmrw
mvwxe

vcifeutpqkmgdl
dqgmtvfluciepk
kqcfgilutvdmpe
kvgcplqmdeutihf
iptvfclukemdgq

gjx
nlzpm
o
khbf

octlvqihe
qgholfnitv
wqhlvit
zksmlxjuiqtdyph

aqtos
staqo

jdiltnsry
nrtylsdjf
tdqnsjylrx
nryjdtlqs
jntsyrdlf

flnmuropqa
nmureafoq
ufkqganmro
uafbnmrtzoq
pauqnmrfo

pealqbmfoycdkn
firhlyjuxtpzgsew

aor
o
o
o
vo

kcfwspmjitevz
piskezfjvtwmuc
twcjzpisvfkem

ufvats
sfa
cfmsayphixwoe
nfktsaq

kbanlrxouw
nwkaobulxr
owaluxknbtr
kxuomabrnlw
uronbtlkwax

sljx
axwlsj
jxls

dcrtnxkhsim
wgfujacenq
gcnbafjw

dh
dh
hdew
hd
dh

uory
ruo
oruy
xuosqrc
oyrut

dsgkweynxcu
zmkiurxhadnlv

zjr
jzr
zrj
zrj
zrj

zd
f

pndukfvawjem
ljedfvnpaw
wdjvbnafqep

fel
ltafmdeq
efn
ehtfa
biswyjufe

grftzue
ezulrqpm
whdkeoinuxsv

qicvgpudfxkbrjwelht
wivdhmeuzcylfbogqarxpjnk

whjkaulxcbp
cwkpljxbhua
acjpklwhxbu
kwjcqhubaxp
hackubpxmwj

nigwj
tcsp

clmudw
gadvjqmkpsbthn
drmel

ikfeorbdvwjg
av
vc
vzcap
hyxmv

u
d
d
y

mdolysecjxpan
yoaxpmecnwsdjl
acjsmplydoxen

tirqchjkbdxaznl
yqxivwtdkrjbazn
ihajzflkqdctbnrx
bqzdtkirnaxje
xjdhitzqknbra

gvxbuleys
fcdahtsrbnyve

o
o
o

bqyuzj
ubzqyj
uzmitrcqjhby
jbazyuq
qwjybzu

g
g
g
p

prbctmvziglneoyk
ezrpcihbknvylto

wyjb
bjwy
bywj
ywjb
fywjb

s
y
y

igx
ixg
gix
igx

vonyrelahsdxfit
esxarhfylotind
ydlfxgsnheiotra
axsftorheliynd

mie
zqm
m
em

csnm
umsiqk
podfhgraweyvz
l

xcfbphtsj
hsxpmwqtbufjr
pxvjftsbh

rbpgfoud
otcz
xmseohv
hkinzo
ylov

eorb
qlvfh
yvlqwm

nxlcsgumvtqoj
smtygqjucvn
suemcvtyqnjgp
cvmgnfjstqu

dtg
pglte
ngt

eysdmnfgqrivklcpxabhutowj
wgkcalmsinouqeyfvdptrbx

hwrjdasze
rjhsdweza
sedzjhwra
zjdxhswrae
rejhzaswd

ykembxfuvzicgortln
ocgxewniplthzrbu
cfmsluzogvixrdbetnq";

        [Test]
        public void CountingIsDistinct()
        {
            var sample = @"ab
ac";

            var d6 = new CustomCustoms();
            var count = d6.GetSumOfCount(sample);

            count.Should().Be(3);
        }

        [Test]
        public void Example()
        {
            var sample = @"abc

a
b
c

ab
ac

a
a
a
a

b";

            var d6 = new CustomCustoms();
            var count = d6.GetSumOfCount(sample);

            count.Should().Be(11);
        }

        [Test]
        public void Run()
        {
            var d6 = new CustomCustoms();
            var count = d6.GetSumOfCount(_puzzle);

            count.Should().Be(6161);
        }
    }
}