<script setup lang="ts">
import { ref, onMounted } from 'vue';
import ContentLayout from '@/components/ContentLayout.vue';
import ProductDetails from '@/components/ProductDetails.vue';
import type ProductDetailsModel from "@/models/ProductDetails";

let data = ref<ProductDetailsModel[]>();

onMounted(async () => {
    let request = await fetch("../src/assets/seaurchins.json");
    data.value = await request.json();    
})
</script>

<template>
    <ContentLayout>
        <template #header>Sea Urchin</template>
        <template #blurb>
            Sea Urchins are an ancient life form known as echinoderms, which include starfish and sea cucumbers. Sea
            urchins have been eaten as a traditional food by many cultures around the world for tens of thousands of
            years. The quality of NSW sea urchin is world class and are now being exported overseas as a delicacy. In
            many parts of NSW sea urchins are considered to be over abundant and are causing “urchin barrens” which is
            the local extinction of seaweed beds. The collection of sea urchins is helping to restore this balance
            allowing seaweed regeneration. The NSW sea urchin fishery is considered to be a highly sustainable and well
            managed fishery. All sea urchins are collected by hand, one at a time. This ensures minimal disturbance to
            marine habitat. By eating sea urchins, you are helping to protect our coastal inshore reefs.
        </template>
        <template #page-content>
            <div v-for="(item, index) in data" v-bind:key="index" class="py-3">
                <ProductDetails :index=index v-bind:model=item></ProductDetails>
            </div>            
        </template>
    </ContentLayout>
</template>