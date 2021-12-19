to apply updates:

az webapp up --os-type linux

to create initial web app:

az login
az webapp up --sku B1 --location westeurope --name freelance-direkt --os-type linux  --resource-group dnw-rg  --plan dnw-plan

to remove resources:

az group delete --name jeroen_bijlsma_rg_5807
az appservice plan delete --name jeroen_bijlsma_asp_7308

to deploy successfully using github actions to the azure app service, you need to set the 
SCM_DO_BUILD_DURING_DEPLOYMENT setting to false for the app service  